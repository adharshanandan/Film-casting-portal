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
    public partial class CastingCallDetails : System.Web.UI.Page
    {
        CastingCallManager CastMng_Obj = new CastingCallManager();
        ActorManager ActorMng_Obj = new ActorManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int CId = Convert.ToInt32(Request.QueryString["id"]);
                CastingViewDetails(CId);
                AppliedOrNot();
            }
            

        }
        public void CastingViewDetails(int CId)
        {
            CastMng_Obj.CastProp_Obj.CastId = CId;
            CastMng_Obj.GetCastDetailsbyId();
            LabExp.Text = CastMng_Obj.CastProp_Obj.PreExperience+" Required!!";
            LabGender.Text = CastMng_Obj.CastProp_Obj.PreGender;
            LabNoActor.Text = CastMng_Obj.CastProp_Obj.NoOfActors.ToString();
            LabAgeBetween.Text = CastMng_Obj.CastProp_Obj.AgeFrom.ToString() + " to " + CastMng_Obj.CastProp_Obj.AgeTo.ToString();
            LabLoc.Text = CastMng_Obj.CastProp_Obj.PreDist + "," + CastMng_Obj.CastProp_Obj.PreState + "," + CastMng_Obj.CastProp_Obj.PreCountry;
            LabSkintone.Text = CastMng_Obj.CastProp_Obj.PreSkinCol;
            LabHairCol.Text = CastMng_Obj.CastProp_Obj.PreHairCol;
            LabEyeCol.Text = CastMng_Obj.CastProp_Obj.PreEyeCol;
            LabBody.Text = CastMng_Obj.CastProp_Obj.PreBodyStruct;
            LabHeight.Text = CastMng_Obj.CastProp_Obj.PreHeight.ToString();
            LabCharDesc.Text = CastMng_Obj.CastProp_Obj.CharacterDiscription;
            LabPostedDate.Text =Convert.ToDateTime(CastMng_Obj.CastProp_Obj.PostedDate).ToShortDateString();
            LabEndDate.Text = Convert.ToDateTime(CastMng_Obj.CastProp_Obj.LastDate).ToShortDateString();




        }

        protected void BtnApply_Click(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                if (BtnApply.Text == "Apply")
                {
                    string ActorEmail = Session["Actor"].ToString();
                    CastMng_Obj.CastProp_Obj.CastId = Convert.ToInt32(Request.QueryString["id"]);
                    string result = CastMng_Obj.ApplicantInsert(ActorEmail);
                    if (result == "Error")
                    {
                        LabMsg.Visible = true;
                        LabMsg.ForeColor = System.Drawing.Color.Red;
                        LabMsg.Text = "Error Occured!";

                    }
                    else if (result == "Success")
                    {
                        LabMsg.Visible = true;
                        LabMsg.ForeColor = System.Drawing.Color.Green;
                        LabMsg.Text = "Applied successfully";
                        BtnApply.Text = "Applied";
                        BtnApply.Enabled = false;
                        BtnApply.BorderColor = System.Drawing.Color.Gray;
                        BtnApply.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        LabMsg.Visible = true;
                        LabMsg.ForeColor = System.Drawing.Color.Red;
                        LabMsg.Text = "Error Occured due to technical problem!";
                    }


                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.ForeColor = System.Drawing.Color.Red;
                    LabMsg.Text = "Already Applied!!";

                }

            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                Response.Redirect("~/ActorPages/ActorHomePage.aspx");
            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
        }
        public void AppliedOrNot()
        {

            if (Session["Actor"] != null)
            {
                string ActorEmail = Session["Actor"].ToString();
                CastMng_Obj.CastProp_Obj.CastId = Convert.ToInt32(Request.QueryString["id"]);
                string result = CastMng_Obj.ApplicantExist(ActorEmail);
                if (result == "Exist")
                {
                    BtnApply.Text = "Applied";
                    BtnApply.Enabled = false;
                    BtnApply.BorderColor = System.Drawing.Color.Gray;
                    BtnApply.BackColor = System.Drawing.Color.Gray;

                }
                else if (result == "Not Exist")
                {
                    BtnApply.Text = "Apply";
                }
              

            }

        }
    }
}