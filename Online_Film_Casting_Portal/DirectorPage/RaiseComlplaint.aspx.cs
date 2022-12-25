using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;
using BusinessLogicLayer.Actor.ActorManager;

namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class RaiseComlplaint : System.Web.UI.Page
    {
        DirManager DirMng_Obj = new DirManager();
        ActorManager ActMng_Obj = new ActorManager();
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
            
                this.Page.MasterPageFile = "~/ActorPages/ActorMaster.Master";

            }
            
            else if (Session["Director"] != null)
            {
               
                this.Page.MasterPageFile = "~/DirectorPage/DirectorMaster.Master";

            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
          
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void BtnAddCom_Click(object sender, EventArgs e)
        {
            if (Session["Director"] != null)
            {
                DirMng_Obj.DirProp_Obj.DirEmail = Session["Director"].ToString();
                DirMng_Obj.ComPropObj.Complaints = TxtCom.Text.Trim();
                string result = DirMng_Obj.InsertComplaint();
                CommonMsg(result);
  
            }
            else if (Session["Actor"] != null)
            {
                ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                ActMng_Obj.ComProp_Obj.Complaints = TxtCom.Text.Trim();
                string result = ActMng_Obj.InsertComplaint();
                CommonMsg(result);
            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
        }

        protected void BtnClrFaq_Click(object sender, EventArgs e)
        {
            TxtCom.Text = "";
            LabMsg.Text = "";
           

        }
        public void CommonMsg(string result)
        {
            if (result == "Error")
            {
                LabMsg.Visible = true;
                LabMsg.CssClass = "alert alert-danger";
                LabMsg.Text = "Error Occured!";
            }
            else if (result == "Success")
            {
                LabMsg.Visible = true;
                LabMsg.CssClass = "alert alert-success";
                TxtCom.Text = "";
                LabMsg.Text = "Submitted.";
            }
            else if (result == "Exist")
            {
                LabMsg.Visible = true;
                LabMsg.CssClass = "alert alert-danger";
                LabMsg.Text = "Already submitted";
            }
            else
            {
                LabMsg.Visible = true;
                LabMsg.CssClass = "alert alert-danger";
                LabMsg.Text = "Technical issue. Try after sometime";

            }
        }
    }
}