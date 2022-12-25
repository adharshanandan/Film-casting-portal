using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;
using BusinessLogicLayer.Actor.ActorManager;
using System.Collections;
using System.Text;

namespace Online_Film_Casting_Portal.ActorPages
{
    public partial class ActorHomePage : System.Web.UI.Page
    {
        CastingCallManager CastMng_Obj = new CastingCallManager();
        DirManager DirMng_Obj = new DirManager();
        ActorManager ActorMng_Obj = new ActorManager();
        SortedList S1 = new SortedList();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCallsDetails();
                GetDirDetailsToHome();
                AgeBind();
                
            }
            if (Session["Actor"] == null)
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }

        }
        public void GetCallsDetails()
        {
            if (Session["Actor"] != null)
            {
                CastMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                DlCalls.DataSource = CastMng_Obj.GetCallDetails("CastDetailsBind");
                DlCalls.DataBind();
                LabCount.Visible = true;
                LabCount.Text = CastMng_Obj.CastProp_Obj.Count.ToString() + " Calls found...";


            }
        }
        public void GetDirDetailsToHome()
        {
            if (Session["Actor"] != null)
            {
                DirMng_Obj.DirProp_Obj.DirEmail = Session["Actor"].ToString();
                DlDirDetails.DataSource = DirMng_Obj.SelectDirDetailsToHome();
                DlDirDetails.DataBind();
            }
        }

        public void AgeBind()
        {
           
            int Age = 15;
            int i;
            ArrayList AlAge = new ArrayList();
            AlAge.Add("All");
            for ( i = 1; i < 66; ++i)
            {
                AlAge.Add(Age);
                Age++;
            }
            DDAge.DataSource = AlAge;
            DDAge.DataBind();

        }


        protected void DlDirDetails_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("DirId"))
            {
                int DirId = Convert.ToInt32(DlDirDetails.DataKeys[e.Item.ItemIndex]);
                
                if (Session["Actor"] != null)
                {
                    ActorMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                    string result = ActorMng_Obj.FollowersDataInsert(DirId);
                    Button btn = (e.Item.FindControl("BtnFollow") as Button);

                    if (result == "Success")
                    {
                        btn.Enabled = false;
                        btn.Text = "Followed";
                        GetCallsDetails();

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Already Followed')", true);
                    }
                }
            }
        }

        protected void DDIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {    
            FilterCastingCalls();
        }

        protected void DDExp_SelectedIndexChanged(object sender, EventArgs e)
        {

             FilterCastingCalls();

        }

        protected void DDAge_SelectedIndexChanged(object sender, EventArgs e)
        {

            FilterCastingCalls();

        }

        protected void BtnRefresh_Click(object sender, EventArgs e)
        {
            DDAge.SelectedIndex = 0;
            DDExp.SelectedIndex = 0;
            DDIndustry.SelectedIndex = 0;
            GetCallsDetails();
        }

        protected void BtnFindDir_ServerClick(object sender, EventArgs e)
        {
            string KeywordTxt = TxtFindDir.Text.ToString();
            if (Session["Actor"] != null)
            {
                DirMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                DlDirDetails.DataSource = DirMng_Obj.SelectDirbySearch("SearchOnUnfollowingDirList", KeywordTxt);
                DlDirDetails.DataBind();
            }


        }

       
        public void FilterCastingCalls()
        {
            StringBuilder strQuery = new StringBuilder();
            string prefix = "and";
            strQuery.Append("select CastId,MovieName,ProductionName,PreExperience,CharacterDiscription,AgeFrom,AgeTo,PostedDate,LastDate,MovieLanguage,PreGender from CastingCallDetails where DirectorId in (select FDirId from Followers where FActorId in (select ActorId from ActorDetails where ActorEmail = '"+Session["Actor"].ToString()+"'))");
            if (DDAge.SelectedIndex != 0) 
            {
                strQuery.Append(" "+prefix + " AgeFrom <= '"+DDAge.SelectedValue+ "' and AgeTo>= '" + DDAge.SelectedValue + "'");
            }
            if (DDExp.SelectedIndex != 0)
            {
                strQuery.Append(" "+prefix + " PreExperience = '" + DDExp.SelectedValue + "'");
            }
            if (DDIndustry.SelectedIndex != 0)
            {
                strQuery.Append(" "+prefix + " MovieLanguage = '" + DDIndustry.SelectedValue + "'");
            }

            DlCalls.DataSource = CastMng_Obj.CallDetailsFilter(strQuery.ToString());
            LabCount.Visible = true;
            LabCount.Text = CastMng_Obj.CastProp_Obj.Count.ToString() + " Calls found...";
            DlCalls.DataBind();
            if(DDExp.SelectedIndex==0 && DDAge.SelectedIndex==0 && DDIndustry.SelectedIndex == 0)
            {
                GetCallsDetails();
            }
        }
    }
}