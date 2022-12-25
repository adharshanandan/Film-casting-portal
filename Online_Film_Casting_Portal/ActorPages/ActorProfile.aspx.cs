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
    public partial class ActorProfile : System.Web.UI.Page
    {
        ActorManager ActMng_Obj = new ActorManager();

        protected void Page_PreInit(object sender, EventArgs e)
        {
            // To change master pages according to the users
            try
            {
                if (Session["Actor"] != null)
                {
                    this.Page.MasterPageFile = "~/ActorPages/ActorMaster.Master";

                }
                    
                else if(Session["Director"] != null)
                {
                    this.Page.MasterPageFile = "~/DirectorPage/DirectorMaster.Master";
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+ex.Message+"')", true);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Actor"] != null)
                {
                    ProfileBind();
                    BtnCancel.Visible = false;
                    BtnUploadVds.Visible = false;
                    TxtCap.Visible = false;
                    VideoDLBind();
                }
                else if (Session["Director"] != null)
                {
                    ProfileBind();
                    BtnCancel.Visible = false;
                    BtnUploadVds.Visible = false;
                    TxtCap.Visible = false;
                    VideoDLBind();
                    BtnUpload.Visible = false;
                    BtnEdit.Visible = false;
                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }
                
            }
            
        }
        public void ProfileBind()
        {
            if (Session["Actor"] != null)
            {
                ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                ActMng_Obj.SelectActorDetails("ActorDetailsToProfile");
                GetActorDetails();
            }
            if (Session["Director"] != null)
            {
                if (Session["ActorView"] != null)
                {
                    ActMng_Obj.RegProp_Obj.ActorEmail = Session["ActorView"].ToString();
                    ActMng_Obj.SelectActorDetails("ActorDetailsToProfile");
                    GetActorDetails();

                }
                else
                {
                    Response.Redirect("~/DirectorPage/ApplicantListPage.aspx");
                }
                

            }
        }

        public void GetActorDetails()
        {
            if (ActMng_Obj.RegProp_Obj.ActorAccStatus == 'A')
            {
                if (ActMng_Obj.RegProp_Obj.AccType == "Normal")
                {
                    ImgBadge.Visible = false;
                    
                }
                else if (ActMng_Obj.RegProp_Obj.AccType == "Premium")
                {
                    if((Session["Director"] != null))
                    {
                        if (Session["ActorView"] != null)
                        {
                            ActMng_Obj.RegProp_Obj.ActorEmail = Session["ActorView"].ToString();
                            DateTime EndDate = ActMng_Obj.GetPremiumEndDate();
                            if (DateTime.Now >= EndDate)
                            {
                                ImgBadge.Visible = false;
                               
                            }
                            else
                            {
                                ImgBadge.Visible = true;
                                ImgBadge.ImageUrl = "~/ActorPages/PamentPageBg/premium-quality.png";
                            }
                        }

                    }
                    if (Session["Actor"] != null)
                    {
                        ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                        DateTime EndDate = ActMng_Obj.GetPremiumEndDate();
                        if (DateTime.Now >= EndDate)
                        {
                            ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                            string result = ActMng_Obj.ChangePremiumToNormal();
                            if (result == "Success")
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Your Premium subscription has been ended. Please pay and use our premium services)", true);
                                GetActorDetails();
                                ImgBadge.Visible = false;
                            }
                            else if (result == "Error")
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Error Occured!! Please login after sometime)", true);
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Error Occured!! Please login after sometime)", true);
                            }
                        }
                        else
                        {
                            ImgBadge.Visible = true;
                            ImgBadge.ImageUrl = "~/ActorPages/PamentPageBg/premium-quality.png";
                        }

                    }
                    
                   

                    
                }
                LabName.Text = ActMng_Obj.RegProp_Obj.ActorName;
                LabPlace.Text = ActMng_Obj.RegProp_Obj.ActorState + "," + ActMng_Obj.RegProp_Obj.ActorDist;
                if (ActMng_Obj.RegProp_Obj.ProPicActor == null)
                {
                    ImgMapProfilePic.ImageUrl = "~/ActorPages/ActorProPics/usercommon.png";
                }
                else
                {
                    ImgMapProfilePic.ImageUrl = ActMng_Obj.RegProp_Obj.ProPicActor;

                }

                LabId.Text = ActMng_Obj.RegProp_Obj.ActorId.ToString();
                LabGender.Text = ActMng_Obj.RegProp_Obj.ActorGender;
                LabCntry.Text = ActMng_Obj.RegProp_Obj.ActorCountry;
                LabDob.Text = ActMng_Obj.RegProp_Obj.ActorDob.ToShortDateString();
                LabAddress.Text = ActMng_Obj.RegProp_Obj.ActorAddress;
                LabZip.Text = ActMng_Obj.RegProp_Obj.ActorZip;
                LabExp.Text = ActMng_Obj.RegProp_Obj.NeworExperienced;
                LabSkin.Text = ActMng_Obj.RegProp_Obj.SkinColor;
                LabMTng.Text = ActMng_Obj.RegProp_Obj.ActorMTng;
                LabHair.Text = ActMng_Obj.RegProp_Obj.HairCol;
                LabEye.Text = ActMng_Obj.RegProp_Obj.EyeCol;
                LabBody.Text = ActMng_Obj.RegProp_Obj.BodyStruct;
                LabHeight.Text = ActMng_Obj.RegProp_Obj.Height.ToString();
                LabPh.Text = ActMng_Obj.RegProp_Obj.ActorPhone;
                LabEmail.Text = ActMng_Obj.RegProp_Obj.ActorEmail;
                LabPreW.Text = ActMng_Obj.RegProp_Obj.PreviousWorks;
            }
        }

     

        protected void BtnEdit_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/ActorPages/ActorProfileEdit.aspx");

        }

        protected void BtnUpload_ServerClick(object sender, EventArgs e)
        {
            FuVds.Visible = true;
            BtnCancel.Visible = true;
            BtnUploadVds.Visible = true;
            TxtCap.Visible = true;
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            FuVds.Visible = false;
            BtnCancel.Visible = false;
            BtnUploadVds.Visible = false;
            TxtCap.Visible = false;
        }

        protected void BtnUploadVds_Click(object sender, EventArgs e)
        {
            try
            {
                if (FuVds.HasFile && FuVds.PostedFile.ContentLength < 10240000)
                {
                    string FileName = Path.GetFileName(FuVds.FileName);
                    string Extention = Path.GetExtension(FuVds.FileName);
                    if (Extention == ".mp4")
                    {
                        string VideoPath;
                        FuVds.SaveAs(Server.MapPath("~/ActorPages/Videos/") + FileName);
                        VideoPath = (Convert.ToString("~/ActorPages/Videos/") + FileName);
                        ActMng_Obj.VidProp_Obj.VideoLink = VideoPath;
                    }
                    else
                    {
                        FuVds.Dispose();
                    }
                    ActMng_Obj.VidProp_Obj.Caption = TxtCap.Text.ToString();
                    ActMng_Obj.VidProp_Obj.UploadedDate = DateTime.Now;
                    if (Session["Actor"] != null)
                    {
                        ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                    }


                    string result = ActMng_Obj.VideosInsert();
                    if (result == "Error")
                    {
                        LabMsg.Visible = true;
                        LabMsg.CssClass = "alert alert-danger";
                        LabMsg.Text = "Upload failed!!";
                    }
                    else if (result == "Success")
                    {
                        LabMsg.Visible = true;
                        LabMsg.CssClass = "alert alert-success";
                        LabMsg.Text = "Uploaded succesfully";
                        VideoDLBind();

                    }
                    else if (result == "Exist")
                    {
                        LabMsg.Visible = true;
                        LabMsg.CssClass = "alert alert-danger";
                        LabMsg.Text = "Already Exists!!";
                    }
                    else
                    {
                        LabMsg.Visible = true;
                        LabMsg.CssClass = "alert alert-danger";
                        LabMsg.Text = "Error!! Please try after sometime.";

                    }
                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.CssClass = "alert alert-danger";
                    LabMsg.Text = "Video size must be less than 10Mb";

                }
               


            }
           
            finally
            {
                TxtCap.Visible = false;
                FuVds.Visible = false;
                BtnCancel.Visible = false;
                BtnUpload.Visible = true;
                BtnUploadVds.Visible = false;
                
            }
            
            
        }
        public void VideoDLBind()
        {
            if (Session["Actor"] != null)
            {
                ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                DlVideos.DataSource = ActMng_Obj.VideosDataBind();
                DlVideos.DataBind();

            }
            if (Session["Director"] != null)
            {
                if (Session["ActorView"] != null)
                {
                    ActMng_Obj.RegProp_Obj.ActorEmail = Session["ActorView"].ToString();
                    DlVideos.DataSource = ActMng_Obj.VideosDataBind();
                    DlVideos.DataBind();

                }
                else
                {
                    Response.Redirect("~/DirectorPage/ApplicantListPage.aspx");
                }
            }
            
            
        }

       
        protected void DlVideos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("RmvCmd"))
            {
                ActMng_Obj.VidProp_Obj.VidId = Convert.ToInt32(DlVideos.DataKeys[e.Item.ItemIndex]);
                if (Session["Actor"] != null)
                {
                    ActMng_Obj.RegProp_Obj.ActorEmail = Session["Actor"].ToString();
                    string result = ActMng_Obj.VideoDelete();
                    Button btn = (e.Item.FindControl("BtnRemove") as Button);

                    if (result == "Error")
                    {
                        btn.Enabled = false;
                        btn.Text = "Followed";


                    }
                    if (result == "Success")
                    {
                        VideoDLBind();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Deleted!!')", true);
                    }
                }
            }
        }
    }
}