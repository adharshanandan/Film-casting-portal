using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Actor.ActorManager;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Online_Film_Casting_Portal.ActorPages
{
    public partial class ActorRegistration : System.Web.UI.Page
    {
        ActorManager ActorMng_Obj = new ActorManager();
        static string VerCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Alert"] != null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Account is deleted. Please sign up to new account.')", true);
                Session.Abandon();
            }


        }

        protected void BtnFormSubmit_Click(object sender, EventArgs e)
        {
            if (CbTerms.Checked == true && LabCodeMsg.Text== "Verified")
            {
                ActorMng_Obj.RegProp_Obj.ActorName = txtFnameActor.Text.ToString() + " " + txtLnameActor.Text.ToString();
                ActorMng_Obj.RegProp_Obj.ActorAddress = TxtAddressActor.Text.ToString();
                ActorMng_Obj.RegProp_Obj.ActorDob = Convert.ToDateTime(TxtDobActor.Text).Date;
                ActorMng_Obj.RegProp_Obj.ActorCountry = DdCtryActor.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.ActorDist = DdDistActor.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.ActorState = DdStateActor.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.ActorGender = RbGender.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.ActorZip = TxtZipActor.Text.ToString();
                ActorMng_Obj.RegProp_Obj.NeworExperienced = DDActExp.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.SkinColor = DDSkinCol.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.ActorMTng = DDMTongue.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.HairCol = DDHairCol.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.EyeCol = DDEyeCol.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.BodyStruct = DDBodyStruct.SelectedValue.ToString();
                ActorMng_Obj.RegProp_Obj.ActorEmail = TxtEmail.Text.ToString();
                ActorMng_Obj.RegProp_Obj.ActorPswd = TxtPswd.Text.ToString();
                ActorMng_Obj.RegProp_Obj.ActorPhone = TxtPhActor.Text.ToString();
                ActorMng_Obj.RegProp_Obj.Height = Convert.ToInt32(TxtHeight.Text);
                ActorMng_Obj.RegProp_Obj.PreviousWorks = TxtPrevWrks.Text.ToString();

                if (FuPropicActor.HasFile)
                {
                    string filename = Path.GetFileName(FuPropicActor.FileName);
                    string extension = Path.GetExtension(FuPropicActor.FileName);

                    if (extension == ".jpeg" || extension == ".jpg" || extension == ".png")
                    {
                        string ImgPath;
                        FuPropicActor.SaveAs(Server.MapPath("~/ActorPages/ActorProPics/") + filename);
                        ImgPath = (Convert.ToString("~/ActorPages/ActorProPics/") + filename);
                        ActorMng_Obj.RegProp_Obj.ProPicActor = ImgPath;
                        
                    }
                    else
                    {
                        FuPropicActor.Dispose();
                    }
                }
                string result = ActorMng_Obj.InsertActorData();
                if (result == "Error")
                {
                    LabelMessage();
               
                    LabMsgRegDir.Text = "Error Occured";

                }
                else if(result=="Email Exists")
                {
                    LabelMessage();
                    LabMsgRegDir.Text = "Email Already Exists";

                }
                else if(result=="Password Exists")
                {
                    LabelMessage();
                    LabMsgRegDir.Text = "Try another password";

                }
                else if (result == "Success")
                {
                    /* Session["Status"] is created for checking whether the registration has been completed 
                     successfully and to show an alert message to the user */

                    Session["Status"] = "Success";
                    Response.Redirect("~/HomePage/LoginForm.aspx");

                }
                else
                {
                    LabelMessage();
                    LabMsgRegDir.Text = "Error due to technical issue";

                }

            }
             else if (CbTerms.Checked == false)
            {

                LabelMessage();
                LabMsgRegDir.Text = "Please agree!!";

            }
            else if (LabCodeMsg.Text != "Verified")
            {
                LabelMessage();
                LabMsgRegDir.Text = "Please verify your Email!!";
            }

        }

        public void LabelMessage()
        {
            LabMsgRegDir.Visible = true;
            LabMsgRegDir.ForeColor = System.Drawing.Color.Red;

        }
         

        protected void BtnFormReset_Click(object sender, EventArgs e)
        {
            txtFnameActor.Text = "";
            txtLnameActor.Text = "";
            TxtAddressActor.Text = "";
            TxtDobActor.Text = "";
            TxtZipActor.Text = "";
            TxtEmail.Text = "";
            TxtPswd.Text = "";
            TxtPhActor.Text = "";
            TxtHeight.Text = "";
            TxtPrevWrks.Text = "";


        }

        // Random code generating function
        protected void LbEmailVerify_Click(object sender, EventArgs e)
        {
            LabCodeMsg.Visible = true;
            TxtVerifyCode.Visible = true;
            LbEmailVerify.Text = "Resend";
            
            Random RandNo = new Random();
            VerCode = RandNo.Next(100001, 999999).ToString();
            SendMail();

        }

        protected void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            LbEmailVerify.Visible = true;
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
            msg.Body = "Dear " + txtFnameActor.Text + " " + txtLnameActor.Text + ",\n\n" + "Your verification code is : " + VerCode + "\n\n Thanks & Regards\n Fcp Team";
            msg.To.Add(TxtEmail.Text.ToString());
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
    }
}