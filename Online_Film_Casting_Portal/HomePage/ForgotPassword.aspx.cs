using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using BusinessLogicLayer.Actor.ActorManager;
using BusinessLogicLayer.Director.DirectorManager;
using BusinessLogicLayer;


namespace Online_Film_Casting_Portal.HomePage
{
    
    public partial class ForgotPassword : System.Web.UI.Page
    {
        ActorManager ActorMng_Obj = new ActorManager();
        DirManager DirMng_Obj = new DirManager();
        AdminManager AdmMng_Obj = new AdminManager();
        
        // Vercode has been declared as static because the generated code should not be change.

        static string VerCode;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // TextChanged event used to ensure the entered username is available in the database
        protected void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            string result;
            Session["user"] = DDUsers.SelectedValue.ToString();
            if (Session["user"] != null)
            {
                if (Session["user"].ToString() == "Actor")
                {
                    ActorMng_Obj.RegProp_Obj.ActorEmail = TxtEmail.Text.ToString();
                    result = ActorMng_Obj.ValidUserOrNot();
                    CommonResult(result);
                }
                else if (Session["user"].ToString() == "Admin")
                {
                    AdmMng_Obj.AdmProp_Obj.AdminUsername = TxtEmail.Text.ToString();
                    result = AdmMng_Obj.ValidAdmOrNot();
                    CommonResult(result);

                }
                else if (Session["user"].ToString() == "Director")
                {
                    DirMng_Obj.DirProp_Obj.DirEmail = TxtEmail.Text.ToString();
                    result = DirMng_Obj.ValidDirOrNot();
                    CommonResult(result);

                }

            }

        }

        protected void txtFPswd_TextChanged(object sender, EventArgs e)
        {
            if (VerCode == txtFPswd.Text.ToString())
            {
                LabCodeMsg.Visible = true;
                LabCodeMsg.ForeColor = System.Drawing.Color.Green;
                LabCodeMsg.Text = "Verified";
                LabNewCPswd.Visible = true;
                LabNewPswd.Visible = true;
                TxtCPswd.Visible = true;
                TxtPswd.Visible = true;
                LabPswdDes1.Visible = true;
                LabPswdDes2.Visible = true;
                LabPswdDes3.Visible = true;

            }
            else
            {
                LabCodeMsg.Visible = true;
                LabCodeMsg.ForeColor = System.Drawing.Color.Red;
                LabCodeMsg.Text = "Invalid Code";

            }
           
        }

        protected void LbSendCode_Click(object sender, EventArgs e)
        {
            LbSendCode.Text = "Resend";
            Random RandNo = new Random();
            VerCode = RandNo.Next(100001, 999999).ToString();
            SendMail();
        }
        public void SendMail()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("admfcptest@gmail.com", "nyjmvsenvexksqiu");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Reset Password";
            msg.Body = "Dear User,\n\n" + "Your one time password is : " + VerCode + "\n\n Thanks & Regards\n Fcp Team";
            msg.To.Add(TxtEmail.Text.ToString());
            msg.From = new MailAddress("admfcptest@gmail.com");
            try
            {
                smtp.Send(msg);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Code had been sent.')", true);
            }
            catch
            {
                throw;
            }
        }

        protected void BtnResetPswd_Click(object sender, EventArgs e)
        {
            string result;
            ActorMng_Obj.RegProp_Obj.ActorEmail = TxtEmail.Text.Trim();
            ActorMng_Obj.RegProp_Obj.ActorPswd = TxtCPswd.Text.Trim();
            result=ActorMng_Obj.ResetPassword();
            if (result == "Error")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "User not found. Please sign up";

            }
            else if (result == "Success")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Green;
                LabMsg.Text = "Updated successfully. Please login";

            }
            else
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "Sorry for the inconvenience. Please try after sometime";

            }


        }

        public void CommonResult(string result)
        {
            if (result == "NotExist")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "User not found. Please sign up first!!";
                LbSendCode.Visible = false;


            }
            else
            {
                LbSendCode.Visible = true;
                LabMsg.Visible = false;
            }

        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage/LoginForm.aspx");
        }
    }
}