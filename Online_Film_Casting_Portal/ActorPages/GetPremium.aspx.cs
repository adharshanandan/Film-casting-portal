using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Actor.ActorManager;
using System.Net;
using System.Net.Mail;

namespace Online_Film_Casting_Portal.ActorPages
{
    public partial class GetPremium : System.Web.UI.Page
    {

        ActorManager ActMng_Obj = new ActorManager();
        static string VerCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }

        protected void RbMonth_CheckedChanged(object sender, EventArgs e)
        {
            //if (Session["Actor"] != null)
            //{
                TxtAmt.Text = RbMonth.Text.ToString();
            //}
        }

        protected void RbAnnual_CheckedChanged(object sender, EventArgs e)
        {
            //if (Session["Actor"] != null)
            //{
                TxtAmt.Text = RbAnnual.Text.ToString();
            //}

        }
        public void MakePayment()
        {
            ActMng_Obj.PayProp_Obj.AccHolder = TxtAccHolder.Text.Trim();
            ActMng_Obj.PayProp_Obj.BankName = DDBName.SelectedValue.ToString();
            ActMng_Obj.PayProp_Obj.Branch = DDBranch.SelectedValue.ToString();
            ActMng_Obj.PayProp_Obj.IfscCode = TxtIfsc.Text.Trim();
            ActMng_Obj.PayProp_Obj.BAccNo = TxtAccNo.Text.Trim();
            ActMng_Obj.SelectAccMailId();
        }
        public void RandGenerator()
        {
            Random RandNo = new Random();
            VerCode = RandNo.Next(1001, 9999).ToString();
            if(ActMng_Obj.PayProp_Obj.Email!="Not Found")
            {
                SendMail();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Account')", true);
            }
            
        }
       
        public void SendMail()
        {
            if (LabMsg.Text != "Verified!")
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("admfcptest@gmail.com", "nyjmvsenvexksqiu");
                smtp.EnableSsl = true;
                MailMessage msg = new MailMessage();
                msg.Subject = "Payment OTP";
                msg.Body = "Dear " + TxtAccHolder.Text + ",\n\n" + "Your otp is : " + VerCode;
                msg.To.Add(ActMng_Obj.PayProp_Obj.Email);
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
         
           
        }

        protected void LbResend_Click(object sender, EventArgs e)
        {
            MakePayment();
            RandGenerator();
            LbResend.Text = "Resend OTP";
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                Response.Redirect("~/ActorPages/ActorProfile.aspx");
            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
        }

        protected void TxtOtp_TextChanged(object sender, EventArgs e)
        {
            if (VerCode == TxtOtp.Text)
            {
                LabMsg.Visible = true;
                LabMsg.CssClass = "alert alert-success";
                LabMsg.Text = "Verified!";
               
            }
            else
            {
                LabMsg.Visible = true;
                LabMsg.CssClass = "alert alert-danger";
             
                LabMsg.Text = "Invalid OTP!";
               
            }
        }

        protected void BtnPay_Click(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                if (LabMsg.Text == "Verified!")
                {
                    ActMng_Obj.PayProp_Obj.BAccNo = TxtAccNo.Text;
                    ActMng_Obj.PayProp_Obj.Amount = Convert.ToDouble(TxtAmt.Text);
                    ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                    MakePayment();
                  
                    string result = ActMng_Obj.PayAmount();
                    if (result == "Success")
                    {
                        string BalAmt = ActMng_Obj.GetBalanceInfo();
                        string DebitedAmt = TxtAmt.Text;
                        
                        ActMng_Obj.PayProp_Obj.BAccNo = TxtAccNo.Text;
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Payment successfull')", true);
                        
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.Credentials = new NetworkCredential("admfcptest@gmail.com", "nyjmvsenvexksqiu");
                        smtp.EnableSsl = true;
                        MailMessage msg = new MailMessage();
                        msg.Subject = "Transaction details";
                        msg.Body = "Dear " + TxtAccHolder.Text + ",\n\n" + "Rs. " + DebitedAmt+" has been debited from your account"+ "\n\n"+"New Balance : "+BalAmt;
                        msg.To.Add(ActMng_Obj.PayProp_Obj.Email);
                        msg.From = new MailAddress("admfcptest@gmail.com");
                        try
                        {
                            smtp.Send(msg);
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Otp been sent.')", true);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    else if (result == "Error")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Transaction failed!')", true);
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Insufficient Balance!')", true);
                    }
                }
            }
        }
    }
}