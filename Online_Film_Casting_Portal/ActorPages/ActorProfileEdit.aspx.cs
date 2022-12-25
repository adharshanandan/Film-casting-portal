using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Actor.ActorManager;
using System.IO;

namespace Online_Film_Casting_Portal.ActorPages
{
    public partial class ActorProfileEdit : System.Web.UI.Page
    {
        ActorManager ActorMng_Obj = new ActorManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Actor"] != null)
                {
                    ActorDataBind();
                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }

                
            }
           

        }
        public void ActorDataBind()
        {
            if (Session["Actor"] != null)
            {
                ActorMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                ActorMng_Obj.SelectActorDetails("ActorDetailsToProfile");
                LabProPic.Text = ActorMng_Obj.RegProp_Obj.ProPicActor;
                TxtName.Text = ActorMng_Obj.RegProp_Obj.ActorName;
                RbGender.SelectedValue = ActorMng_Obj.RegProp_Obj.ActorGender;
                DdCtryActor.SelectedValue = ActorMng_Obj.RegProp_Obj.ActorCountry;
                DdStateActor.SelectedValue = ActorMng_Obj.RegProp_Obj.ActorState;
                DdDistActor.SelectedValue = ActorMng_Obj.RegProp_Obj.ActorDist;
                TxtAddressActor.Text = ActorMng_Obj.RegProp_Obj.ActorAddress;
                TxtZipActor.Text = ActorMng_Obj.RegProp_Obj.ActorZip;
                TxtDobActor.Text = ActorMng_Obj.RegProp_Obj.ActorDob.ToShortDateString();
                TxtPhActor.Text = ActorMng_Obj.RegProp_Obj.ActorPhone;
                TxtPrevWrks.Text = ActorMng_Obj.RegProp_Obj.PreviousWorks;
                DDActExp.SelectedValue = ActorMng_Obj.RegProp_Obj.NeworExperienced;
                DDMTongue.SelectedValue = ActorMng_Obj.RegProp_Obj.ActorMTng;
                DDBodyStruct.SelectedValue = ActorMng_Obj.RegProp_Obj.BodyStruct;
                DDSkinCol.SelectedValue = ActorMng_Obj.RegProp_Obj.SkinColor;
                DDHairCol.SelectedValue = ActorMng_Obj.RegProp_Obj.HairCol;
                DDEyeCol.SelectedValue = ActorMng_Obj.RegProp_Obj.EyeCol;
                TxtHeight.Text = ActorMng_Obj.RegProp_Obj.Height.ToString();

                
            }
            else
            {
                Session["Expire"] = "Yes";
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }

        }

        

        protected void BtnUpdate_Click1(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                ActorMng_Obj.RegProp_Obj.ActorName = TxtName.Text;
                ActorMng_Obj.RegProp_Obj.ActorGender = RbGender.SelectedValue;

                ActorMng_Obj.RegProp_Obj.ActorDob = Convert.ToDateTime(TxtDobActor.Text);

                ActorMng_Obj.RegProp_Obj.ActorCountry = DdCtryActor.SelectedValue;
                ActorMng_Obj.RegProp_Obj.ActorState = DdStateActor.SelectedValue;
                ActorMng_Obj.RegProp_Obj.ActorDist = DdDistActor.SelectedValue;
                ActorMng_Obj.RegProp_Obj.ActorAddress = TxtAddressActor.Text;
                ActorMng_Obj.RegProp_Obj.ActorZip = TxtZipActor.Text;
                ActorMng_Obj.RegProp_Obj.ActorPhone = TxtPhActor.Text;
                ActorMng_Obj.RegProp_Obj.PreviousWorks = TxtPrevWrks.Text;
                ActorMng_Obj.RegProp_Obj.NeworExperienced = DDActExp.SelectedValue;
                ActorMng_Obj.RegProp_Obj.ActorMTng = DDMTongue.SelectedValue;
                ActorMng_Obj.RegProp_Obj.BodyStruct = DDBodyStruct.SelectedValue;
                ActorMng_Obj.RegProp_Obj.SkinColor = DDSkinCol.SelectedValue;
                ActorMng_Obj.RegProp_Obj.HairCol = DDHairCol.SelectedValue;
                ActorMng_Obj.RegProp_Obj.EyeCol = DDEyeCol.SelectedValue;
                ActorMng_Obj.RegProp_Obj.Height = Convert.ToInt32(TxtHeight.Text);
                if (FuPropicActor.HasFile)
                {
                    string filename = Path.GetFileName(FuPropicActor.FileName);
                    string extension = Path.GetExtension(FuPropicActor.FileName);

                    if (extension == ".jpeg" || extension == ".jpg" || extension == ".png")
                    {
                        string ImgPath;
                        FuPropicActor.SaveAs(Server.MapPath("~/ActorPages/ActorProPics/") + filename);
                        ImgPath = (Convert.ToString("~/ActorPages/ActorProPics/") + filename);
                        ActorMng_Obj.RegProp_Obj.ProPicActor = ImgPath;

                    }
                    else
                    {
                        LabMsg.Visible = true;
                        LabMsg.Text = "Please upload only .jpg/.jpeg/.png files";
                        FuPropicActor.Dispose();
                    }


                }
                else
                {
                    ActorMng_Obj.RegProp_Obj.ProPicActor = LabProPic.Text;
                }
                ActorMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                string result = ActorMng_Obj.UpdatetActorData();
                if (result == "Error")
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Update failed";
                    LabMsg.CssClass = "alert alert-danger";

                }
                else if (result == "Success")
                {
                    //Response.Redirect("~/ActorPages/ActorProfile.aspx");
                    LabMsg.Visible = true;
                    LabMsg.Text = "Updated";
                    LabMsg.CssClass = "alert alert-success";
                    BtnCancel.CssClass = "btn btn-primary btn-lg";
                    BtnCancel.Text = "Back";
                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Sorry for the inconvenience. Please try after sometime";
                    LabMsg.CssClass = "alert alert-danger";
                }
            }
            else
            {
                Session["Expire"] = "Yes";
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }

        }

        protected void BtnCancel_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/ActorPages/ActorProfile.aspx");
        }
    }
}