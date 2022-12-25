using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Film_Casting_Portal.HomePage
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["admin"] != null)
                {
                    BtnLoginHeader.Text = "Logout";
                    BtnSignup.Visible = false;
                }
                else
                {
                    BtnLoginHeader.Text = "Login";
                    BtnSignup.Visible = true;
                }
                

            }
            
        }

        
        protected void BtnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage/Registration.aspx");
        }

        protected void BtnLoginHeader_Click(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                Session.Abandon();
                Response.Redirect("~/HomePage/LoginForm.aspx");
           

            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");

            }
            
        }
    }
}