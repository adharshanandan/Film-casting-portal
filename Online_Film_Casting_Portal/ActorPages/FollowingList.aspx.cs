using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;
using BusinessLogicLayer.Actor.ActorManager;

namespace Online_Film_Casting_Portal.ActorPages
{
    public partial class FollowingList : System.Web.UI.Page
    {
        DirManager DirMng_Obj = new DirManager();
        ActorManager ActMng_Obj = new ActorManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFollowingsList();
                
            }

        }
        public void BindFollowingsList()
        {
            if (Session["Actor"] != null)
            {
                DirMng_Obj.DirProp_Obj.DirEmail = Session["Actor"].ToString();
                DlFollowings.DataSource = DirMng_Obj.SelectActorFollowings();
                DlFollowings.DataBind();

            }

        }

    


        protected void BtnFindDir_ServerClick(object sender, EventArgs e)
        {

            string KeywordTxt = TxtFindDir.Text.ToString();
            if (Session["Actor"] != null)
            {
                DirMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                DlFollowings.DataSource = DirMng_Obj.SelectDirbySearch("SearchOnfollowingDirList", KeywordTxt);
                DlFollowings.DataBind();

            }
        }

      

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Button Btn=sender as Button;
            Session["ViewDirPro"] = Btn.CommandArgument.ToString();
            Response.Redirect("~/DirectorPage/DirectorProfile.aspx");

        }

        protected void BtnUnFollow_Click(object sender, EventArgs e)
        {
            Button BtnFollow = sender as Button;
            ActMng_Obj.DirProp_Obj.DirEmail = BtnFollow.CommandArgument.ToString();
            if (Session["Actor"] != null)
            {
                ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                string result;
                result=ActMng_Obj.UnfollowDirector();
                if (result == "Error")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Error!! Please try after sometime')", true);

                }
                else if (result == "Success")
                {
                    BindFollowingsList();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Unfollowed successfully')", true);
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Error occured')", true);
                }
            }
        }

        protected void DlFollowings_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Button BtnView = e.Item.FindControl("BtnViewProfile") as Button;
            if (Session["Actor"] != null)
            {
                ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                string AccStatus = ActMng_Obj.GetActAccType();
                if (AccStatus == "Normal")
                {
                    BtnView.Visible = false;
                }
            }

        }
    }



   }