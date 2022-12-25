using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace Online_Film_Casting_Portal.AdminPage
{
    public partial class ComplaintsPage : System.Web.UI.Page
    {
        AdminManager Adm_Obj = new AdminManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ComBind();
            }

        }
        public void ComBind()
        {
            if (Session["Admin"] != null)
            {
                GvActorCom.DataSource = Adm_Obj.SelectComplaints("SelectActorComplaints");
                GvDirCom.DataSource = Adm_Obj.SelectComplaints("SelectDirComplaints");
                GvActorCom.DataBind();
                GvDirCom.DataBind();

            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
            
        }
    }
}