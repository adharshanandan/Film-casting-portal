using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;

namespace Online_Film_Casting_Portal.DirectorPage
{
    
    public partial class DirectorProfile : System.Web.UI.Page
    {
        DirManager DirMng_Obj = new DirManager();


        protected void Page_PreInit(object sender, EventArgs e)
        {
            try
            {
                if (Session["Actor"] != null)
                {
                    this.Page.MasterPageFile = "~/ActorPages/ActorMaster.Master";

                }

                else if (Session["Director"] != null)
                {
                    this.Page.MasterPageFile = "~/DirectorPage/DirectorMaster.Master";
                }
               

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message + "')", true);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Director"] != null)
                {
                    ProfileBind();

                }
                else if (Session["Actor"] != null)
                {
                    if (Session["ViewDirPro"] != null)
                    {
                        ProfileBind();
                        BtnEdit.Visible = false;

                    }
                    else
                    {
                        Response.Redirect("~/ActorPages/FollowingList.aspx");
                    }
                   

                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }


            }
        }

        public void ProfileBind()
        {
            if (Session["Director"] != null)
            {
                DirMng_Obj.DirProp_Obj.DirEmail = Session["Director"].ToString();
                DirMng_Obj.SelectDirDetails("DirectorDetailsToProfile");
                DirPersonalDetails();
            }
            if (Session["Actor"] != null)
            {
                if(Session["ViewDirPro"] != null)
                {
                    DirMng_Obj.DirProp_Obj.DirEmail = Session["ViewDirPro"].ToString();
                    DirMng_Obj.SelectDirDetails("DirectorDetailsToProfile");
                    DirPersonalDetails();

                }
                else
                {
                    Response.Redirect("~/ActorPages/FollowingList.aspx");
                }
            }
        }
        public void DirPersonalDetails()
        {
            if (DirMng_Obj.DirProp_Obj.DirAccStatus == 'A')
            {
                LabName.Text = DirMng_Obj.DirProp_Obj.DirName;
                LabPlace.Text = DirMng_Obj.DirProp_Obj.DirDist + "," + DirMng_Obj.DirProp_Obj.DirState;
                LabId.Text = DirMng_Obj.DirProp_Obj.DirId.ToString();
                LabGender.Text = DirMng_Obj.DirProp_Obj.DirGender;
                LabDob.Text = DirMng_Obj.DirProp_Obj.DirDob.ToShortDateString();
                LabAddress.Text = DirMng_Obj.DirProp_Obj.DirAddress;
                LabMemId.Text = DirMng_Obj.DirProp_Obj.MembId;
                LabPh.Text = DirMng_Obj.DirProp_Obj.DirPh;
                LabCntry.Text = DirMng_Obj.DirProp_Obj.DirCountry;
                LabFilmInd.Text = DirMng_Obj.DirProp_Obj.FilmIndustry;
                if (DirMng_Obj.DirProp_Obj.ProPicDir == null)
                {
                    ImgMapProfilePic.ImageUrl = "~/DirectorPage/DirProPics/usercommon.png";
                }
                else
                {
                    ImgMapProfilePic.ImageUrl = DirMng_Obj.DirProp_Obj.ProPicDir;

                }
            }
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DirectorPage/DirProfileEdit.aspx");
        }
    }
}