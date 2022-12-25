using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace Online_Film_Casting_Portal.AdminPage.UserDatabase
{
    public partial class DirectorDetails : System.Web.UI.Page
    {
        AdminManager Adm_Obj = new AdminManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["Admin"] != null)
                {
                    DirListBind();
                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }
            }

        }
        public void DirListBind()
        {
            GvDirList.DataSource = Adm_Obj.SelectDirList("DisplayDirOnAdmPage");

            GvDirList.DataBind();
        }

        protected void LbtnActivate_Click(object sender, EventArgs e)
        {
            LinkButton linkBtn = sender as LinkButton;
            GridViewRow gvr = linkBtn.NamingContainer as GridViewRow;
            string result = Adm_Obj.AccountStatusChange("ActivateDirAccount", Convert.ToInt32(GvDirList.DataKeys[gvr.RowIndex].Value));
            LabelMessage("Activated", result);
        }

        protected void LBtnDeActivate_Click(object sender, EventArgs e)
        {
            LinkButton linkBtn = sender as LinkButton;
            GridViewRow gvr = linkBtn.NamingContainer as GridViewRow;
            string result = Adm_Obj.AccountStatusChange("DeactivateDirAccount", Convert.ToInt32(GvDirList.DataKeys[gvr.RowIndex].Value));
            LabelMessage("Dectivated", result);

        }
        public void LabelMessage(string Msg, string result)
        {
            if (result == "Error")
            {
                LabMsg.Visible = true;
                LabMsg.BackColor = System.Drawing.Color.Red;

                LabMsg.Text = "Error Occured";
            }
            else if (result == "Success")
            {

                if (Msg == "Activated")
                {
                    LabMsg.ForeColor = System.Drawing.Color.White;
                    LabMsg.BackColor = System.Drawing.Color.Green;
                    LabMsg.Text = Msg;
                }
                else
                {
                    LabMsg.ForeColor = System.Drawing.Color.White;
                    LabMsg.BackColor = System.Drawing.Color.Red;
                    LabMsg.Text = Msg;
                }
                LabMsg.Visible = true;

                DirListBind();

            }
            else
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "Failed due to some technical errors!";
            }
        }
    }
}