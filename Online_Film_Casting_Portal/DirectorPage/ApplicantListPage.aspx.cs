using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Actor.ActorManager;
using BusinessLogicLayer.Director.DirectorManager;
using System.Collections;
using System.Text;

namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class ApplicantListPage : System.Web.UI.Page
    {
        ActorManager ActMng_Obj = new ActorManager();
        DirManager DirMng_Obj = new DirManager();
        CastingCallManager CastMng_Obj = new CastingCallManager();
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Director"] != null)
                {
                    ApplicantDetailsBind();
                    CastIdBind();
                    AgeBind();
                    DropDownListState();

                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }
                
            }
            
        }
        public void ApplicantDetailsBind()
        {
            if (Session["Director"] != null)
            {
                ActMng_Obj.RegProp_Obj.ActorEmail = Session["Director"].ToString();

                GvAppList.DataSource = ActMng_Obj.ApplicantDetails();
                GvAppList.DataBind();

            }
            
        }

        protected void BtnView_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gvr = btn.NamingContainer as GridViewRow;
           
            Session["ActorView"]= gvr.Cells[1].Text;

            Response.Redirect("~/ActorPages/ActorProfile.aspx");

        }
        public void AgeBind()
        {

            int Age = 15;
            int i;
            ArrayList AlAge = new ArrayList();
            AlAge.Add("All");
            for (i = 1; i < 66; ++i)
            {
                AlAge.Add(Age);
                Age++;
            }
            DDAge.DataSource = AlAge;
            DDAge.DataBind();

        }
        public void CastIdBind()
        {

            if (Session["Director"] != null)
            {
                string EmailIdDir = Session["Director"].ToString();
                DDCastId.DataSource = DirMng_Obj.GetCastIdsByDir(EmailIdDir);
                DDCastId.DataBind();
                DDCastId.Items.Insert(0, new ListItem("All", "All"));
               


            }

        }

        protected void DDExp_SelectedIndexChanged(object sender, EventArgs e)
        {       
            FilterApplicantsList();
        }

        protected void DDGender_SelectedIndexChanged(object sender, EventArgs e)
        {     
            FilterApplicantsList();
        }

        protected void DDAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterApplicantsList();
        }

        protected void DDDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterApplicantsList();
        }

        protected void DDCastId_SelectedIndexChanged(object sender, EventArgs e)
        {

            FilterApplicantsList();
        }
        public void FilterApplicantsList()
        {
            StringBuilder strQuery = new StringBuilder();
            string prefix = "where";
            strQuery.Append("select ActorEmail,ActorName,Age,ActorGender,ProPicActor,ActorState,ActorDist,NeworExperienced,ActorPh,AccType from ActorDetails ");
            if (DDGender.SelectedIndex!=0)
            {
                strQuery.Append(" " + prefix + " ActorGender = '" + DDGender.SelectedValue + "'");
                prefix = "and";
            }
            if (DDCastId.SelectedIndex != 0)
            {
                strQuery.Append(" " + prefix + " ActorId in (select ApplicantId from Applicants where CastingId='"+DDCastId.SelectedValue+"' )");
                prefix = "and";
            }
            else
            {
                strQuery.Append(" " + prefix + " ActorId in (select ApplicantId from Applicants where CastingId in (select CastId from CastingCallDetails where DirectorId in(select DirId from DirectorDetails where DirEmail='" + Session["Director"] + "')))");
                prefix = "and";
            }
            
            if (DDAge.SelectedIndex != 0)
            {
                strQuery.Append(" " + prefix + " Age <= '" + DDAge.SelectedValue + "'");
                prefix = "and";
            }
            if (DDExp.SelectedIndex != 0)
            {
                strQuery.Append(" " + prefix + " NewOrExperienced = '" + DDExp.SelectedValue + "'");
                prefix = "and";
            }
            if (DDDist.SelectedIndex != 0)
            {
                strQuery.Append(" " + prefix + " ActorDist = '" + DDDist.SelectedValue + "'");
                prefix = "and";
            }
            strQuery.Append(" order by AccType desc");

            GvAppList.DataSource = ActMng_Obj.ApplicantsFilter(strQuery.ToString());
            GvAppList.DataBind();
            if (DDGender.SelectedIndex==0 && DDCastId.SelectedIndex==0 && DDAge.SelectedIndex==0 && DDExp.SelectedIndex==0 && DDDist.SelectedIndex==0)
            {
                ApplicantDetailsBind();
            }
        }

        protected void BtnRefresh_Click(object sender, EventArgs e)
        {
            DropDownListState();
            ApplicantDetailsBind();
        }
        public void DropDownListState()
        {
            DDCastId.SelectedIndex = 0;
            DDAge.SelectedIndex = 0;
            DDGender.SelectedIndex = 0;
            DDExp.SelectedIndex = 0;
            DDDist.SelectedIndex = 0;
        }
    }
}