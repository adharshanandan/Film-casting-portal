using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class DirectorRegistration : System.Web.UI.Page
    {
        DirManager DirMng_Obj = new DirManager();
        static string VerCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Alert"] != null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Account is deleted. Please sign up to new account')", true);
                Session.Abandon();
            }

        }

        public void LabelMessage()
        {
            LabMsgRegDir.Visible = true;
            LabMsgRegDir.ForeColor = System.Drawing.Color.Red;

        }

        protected void LbEmailVerify_Click1(object sender, EventArgs e)
        {
            LabCodeMsg.Visible = true;
            TxtVerifyCode.Visible = true;
            LbEmailVerify.Text = "Resend";

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
            msg.Subject = "Email  verification code";
            msg.Body = "Dear " + txtFnameDir.Text + " " + txtLnameDir.Text + ",\n\n" + "Your verification code is : " + VerCode + "\n\n Thanks & Regards\n Fcp Team";
            msg.To.Add(TxtEmailDir.Text.ToString());
            msg.From = new MailAddress("admfcptest@gmail.com");
            try
            {
                smtp.Send(msg);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Code has been sent.')", true);
            }
            catch
            {
                throw;
            }
        }

        protected void TxtEmailDir_TextChanged(object sender, EventArgs e)
        {
            LbEmailVerify.Visible = true;
        }

        protected void TxtVerifyCode_TextChanged(object sender, EventArgs e)
        {
            if (TxtVerifyCode.Text == VerCode)
            {
                LabCodeMsg.Visible = true;
                LabCodeMsg.ForeColor = System.Drawing.Color.Green;
                LabCodeMsg.Text = "Verified";
            }
            else
            {
                LabCodeMsg.Visible = true;
                LabCodeMsg.ForeColor = System.Drawing.Color.Red;
                LabCodeMsg.Text = "Invalid verification code";

            }
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            txtFnameDir.Text = "";
            txtLnameDir.Text = "";
            RbGender.ClearSelection();
            TxtDobDir.Text = "";
            DdCtryDir.SelectedIndex = 0;
            DdStateDir.SelectedIndex = 0;
            DdDistDir.SelectedIndex = 0;
            TxtMembId.Text = "";
            FuPropicDir.Dispose();
            DdFilmInd.SelectedIndex = 0;
            TxtEmailDir.Text = "";
            TxtPswdDir.Text = "";
            TxtPh.Text = "";
            LabCodeMsg.Text = "";
            LabMsgRegDir.Text = "";
            TxtAddress.Text = "";
            CbTerms.Checked = false;
            TxtVerifyCode.Visible = false;
            LbEmailVerify.Visible = false;

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (CbTerms.Checked == true && LabCodeMsg.Text == "Verified")
            {
                DirMng_Obj.DirProp_Obj.DirName = txtFnameDir.Text.ToString().Trim() + " " + txtLnameDir.Text.ToString().Trim();
                DirMng_Obj.DirProp_Obj.DirAddress = TxtAddress.Text.ToString();
                DirMng_Obj.DirProp_Obj.DirGender = RbGender.SelectedValue.ToString();
                DirMng_Obj.DirProp_Obj.DirDob = Convert.ToDateTime(TxtDobDir.Text).Date;
                DirMng_Obj.DirProp_Obj.DirCountry = DdCtryDir.SelectedValue.ToString();
                DirMng_Obj.DirProp_Obj.DirState = DdStateDir.SelectedValue.ToString();
                DirMng_Obj.DirProp_Obj.DirDist = DdDistDir.SelectedValue.ToString();
                DirMng_Obj.DirProp_Obj.MembId = TxtMembId.Text.ToString();
                DirMng_Obj.DirProp_Obj.FilmIndustry = DdFilmInd.SelectedValue.ToString();
                DirMng_Obj.DirProp_Obj.DirEmail = TxtEmailDir.Text.ToString();
                DirMng_Obj.DirProp_Obj.DirPassword = TxtPswdDir.Text.ToString();
                DirMng_Obj.DirProp_Obj.DirPh = TxtPh.Text.ToString();

                if (FuPropicDir.HasFile)
                {
                    string filename = Path.GetFileName(FuPropicDir.FileName);
                    string extension = Path.GetExtension(FuPropicDir.FileName);

                    if (extension == ".jpeg" || extension == ".jpg" || extension == ".png")
                    {
                        string ImgPath;
                        FuPropicDir.SaveAs(Server.MapPath("~/DirectorPage/DirProPics/") + filename);
                        ImgPath = (Convert.ToString("~/DirectorPage/DirProPics/") + filename);
                        DirMng_Obj.DirProp_Obj.ProPicDir = ImgPath;
                    }
                    else
                    {
                        FuPropicDir.Dispose();
                    }
                }
                string result = DirMng_Obj.InsertDirData();
                if (result == "Error")
                {
                    LabelMessage();

                    LabMsgRegDir.Text = "Error Occured. Please try after sometime.";

                }
                else if (result == "Email Exists")
                {
                    LabelMessage();
                    LabMsgRegDir.Text = "Email Already Exists";

                }
                else if (result == "Password Exists")
                {
                    LabelMessage();
                    LabMsgRegDir.Text = "Try another password";

                }
                else if (result == "Success")
                {
                    
                    Session["Status"] = "Success";
                    Response.Redirect("~/HomePage/LoginForm.aspx");

                }
                else
                {
                    LabelMessage();
                    LabMsgRegDir.Text = "Error due to technical issue. Please try after sometime.";

                }

            }
            else if(CbTerms.Checked==false)
            {
               
                LabelMessage();
                LabMsgRegDir.Text = "Please agree!!";

            }
            else if(LabCodeMsg.Text != "Verified")
            {
                LabelMessage();
                LabMsgRegDir.Text = "Please verify your Email!!";
            }

        }
    }
}