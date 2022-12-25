using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Film_Casting_Portal.AdminPage
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null)
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
            else
            {
                Response.ClearHeaders();
                Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                Response.AddHeader("Pragma", "no-cache");
            }
         

        }

        protected void BtnLogOutMaster_Click(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
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