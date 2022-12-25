using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;
using System.IO;


namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class DirProfileEdit : System.Web.UI.Page
    {
        DirManager DirMng_Obj = new DirManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DirDataBind();
            }
        }
        public void DirDataBind()
        {
            if (Session["Director"] != null)
            {
                DirMng_Obj.DirProp_Obj.DirEmail = Session["Director"].ToString();
                DirMng_Obj.SelectDirDetails("DirectorDetailsToProfile");
                TxtName.Text = DirMng_Obj.DirProp_Obj.DirName;
                RbGender.SelectedValue = DirMng_Obj.DirProp_Obj.DirGender;
                DdCtryDir.SelectedValue = DirMng_Obj.DirProp_Obj.DirCountry;
                DdStateDir.SelectedValue = DirMng_Obj.DirProp_Obj.DirState;
                DdDistDir.SelectedValue = DirMng_Obj.DirProp_Obj.DirDist;
                DDFilmInd.SelectedValue = DirMng_Obj.DirProp_Obj.FilmIndustry;
                TxtDobDir.Text = DirMng_Obj.DirProp_Obj.DirDob.ToShortDateString();
                TxtAddressDir.Text = DirMng_Obj.DirProp_Obj.DirAddress;
                TxtMemId.Text = DirMng_Obj.DirProp_Obj.MembId;
                TxtPhDir.Text = DirMng_Obj.DirProp_Obj.DirPh;
                LabProPic.Visible = true;
                LabProPic.Text = DirMng_Obj.DirProp_Obj.ProPicDir;

            }

        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DirectorPage/DirectorProfile.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Session["Director"] != null)
            {
                DirMng_Obj.DirProp_Obj.DirEmail = Session["Director"].ToString();           
                DirMng_Obj.DirProp_Obj.DirName= TxtName.Text;
                DirMng_Obj.DirProp_Obj.DirGender= RbGender.SelectedValue;
                DirMng_Obj.DirProp_Obj.DirCountry= DdCtryDir.SelectedValue;
                DirMng_Obj.DirProp_Obj.DirState= DdStateDir.SelectedValue;
                DirMng_Obj.DirProp_Obj.DirDist= DdDistDir.SelectedValue;
                DirMng_Obj.DirProp_Obj.FilmIndustry= DDFilmInd.SelectedValue;
                DirMng_Obj.DirProp_Obj.DirDob=Convert.ToDateTime(TxtDobDir.Text);
                DirMng_Obj.DirProp_Obj.DirAddress = TxtAddressDir.Text;
                DirMng_Obj.DirProp_Obj.MembId = TxtMemId.Text;
                DirMng_Obj.DirProp_Obj.DirPh= TxtPhDir.Text;
                if (FuPropicDir.HasFile)
                {
                    string filename = Path.GetFileName(FuPropicDir.FileName);
                    string extension = Path.GetExtension(FuPropicDir.FileName);

                    if (extension == ".jpeg" || extension == ".jpg" || extension == ".png")
                    {
                        string ImgPath;
                        FuPropicDir.SaveAs(Server.MapPath("~/DirectorPage/DirProPics/") + filename);
                        ImgPath = (Convert.ToString("~/DirectorPage/DirProPics/") + filename);
                        DirMng_Obj.DirProp_Obj.ProPicDir = ImgPath;

                    }
                    else
                    {
                        LabMsg.Visible = true;
                        LabMsg.Text = "Please upload only .jpg/.jpeg/.png files";
                        FuPropicDir.Dispose();
                    }
                }
                else
                {
                    DirMng_Obj.DirProp_Obj.ProPicDir = LabProPic.Text;
                }


                string result = DirMng_Obj.UpdateDirData();
                if (result == "Error")
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Update failed";
                }
                else if (result == "Success")
                {
                    Response.Redirect("~/DirectorPage/DirectorProfile.aspx");
                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Sorry for the inconvenience. Please try after sometime";
                }


            }
        
        }
    }
}