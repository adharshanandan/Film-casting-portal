using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.Net;
using System.Net.Mail; 

namespace Online_Film_Casting_Portal.AdminPage
{
    public partial class VisitorMessage : System.Web.UI.Page
    {
        AdminManager AdmMng_Obj = new AdminManager();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMessages();
                SendMailForm.Visible = false;
            }
        }
        public void BindMessages()
        {
            GvVisMsg.DataSource = AdmMng_Obj.GetVisitorsMessage();
            GvVisMsg.DataBind();
        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            Button BtnEmail = sender as Button;
            GridViewRow Gvr = BtnEmail.NamingContainer as GridViewRow;
            
            SendMailForm.Visible = true;

            TxtEmailTo.Text = GvVisMsg.DataKeys[Gvr.RowIndex].Values[0].ToString();
            HidfldName.Value= GvVisMsg.DataKeys[Gvr.RowIndex].Values[1].ToString();
            HidfldId.Value= GvVisMsg.DataKeys[Gvr.RowIndex].Values[2].ToString();

        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtEmailTo.Text = "";
            TxtMsg.Text = "";
            SendMailForm.Visible = false;
        }

        protected void BtnSendEmail_Click(object sender, EventArgs e)
        {
            bool IsMailSent;
            IsMailSent=SendMail();
            TxtMsg.Text = "";
            SendMailForm.Visible = false;
            if (IsMailSent)
            {
                AdmMng_Obj.VisMsgProp_Obj.CusId = Convert.ToInt32(HidfldId.Value);
                string result=AdmMng_Obj.DeleteInquiry();
                BindMessages();
                if (result == "Error")
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error occured during deleting inquiry')", true);
                }
            }
        }
        public bool SendMail()
        {
            bool Mailsent = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("admfcptest@gmail.com", "nyjmvsenvexksqiu");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Reply to your inquiry";
            msg.Body = "Dear "+ HidfldName.Value+","+"\n\n" + TxtMsg.Text + "\n\n Thanks & Regards\n Fcp Team";
            msg.To.Add(TxtEmailTo.Text.Trim());
            msg.From = new MailAddress("admfcptest@gmail.com");
            try
            {
                smtp.Send(msg);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Message has been sent.')", true);
                Mailsent = true;
                return Mailsent;
            }
            catch
            {
                throw;
            }
        }
    }
}