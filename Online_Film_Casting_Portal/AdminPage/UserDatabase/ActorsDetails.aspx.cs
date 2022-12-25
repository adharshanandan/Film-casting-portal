using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace Online_Film_Casting_Portal.AdminPage.UserDatabase
{
    public partial class ActorsDetails : System.Web.UI.Page
    {
        AdminManager Adm_Obj=new AdminManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["Admin"] != null)
                {
                    ActorListBind();
                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }
            }
        }
        public void ActorListBind()
        {
            GvActorList.DataSource = Adm_Obj.SelectActorList("DisplayActorOnAdmPage");
           
            GvActorList.DataBind();
        }

        //public void FaqDelete(String SelId)
        //{
        //    Adm_obj.FaqProp_Obj.Id = Convert.ToInt32(SelId);
        //    string result;
        //    result = Adm_obj.DeleteFromFaq("FaqDelete");
        //    LabelMessage(result);


        //}
        //protected void ImgBtnFaqDelete_Click(object sender, ImageClickEventArgs e)
        //{
        //    ImageButton imgBtn = sender as ImageButton;
        //    GridViewRow gvr = imgBtn.NamingContainer as GridViewRow;
        //    FaqDelete(GvFaq.DataKeys[gvr.RowIndex].Value.ToString());
        //    RfvFaqAns.Enabled = false;
        //    RfvFaqQn.Enabled = false;


        //}
       
        protected void LbtnActivate_Click(object sender, EventArgs e)
        {
            LinkButton linkBtn = sender as LinkButton;
            GridViewRow gvr = linkBtn.NamingContainer as GridViewRow;
            string result=Adm_Obj.AccountStatusChange("ActivateAccount",Convert.ToInt32( GvActorList.DataKeys[gvr.RowIndex].Value));
            LabelMessage("Activated", result);


        }

        protected void LBtnDeActivate_Click(object sender, EventArgs e)
        {
            LinkButton linkBtn = sender as LinkButton;
            GridViewRow gvr = linkBtn.NamingContainer as GridViewRow;
            string result = Adm_Obj.AccountStatusChange("DeActivateAccount", Convert.ToInt32(GvActorList.DataKeys[gvr.RowIndex].Value));
            LabelMessage("Dectivated", result);

        }
        public void LabelMessage(string Msg,string result)
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
                
                ActorListBind();

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