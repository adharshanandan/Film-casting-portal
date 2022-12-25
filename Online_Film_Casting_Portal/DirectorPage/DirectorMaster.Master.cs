using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;

namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class DirectorMaster : System.Web.UI.MasterPage
    {
        DirManager DirMng_Obj = new DirManager();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Director"] == null)
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
            else
            {
                Response.ClearHeaders();
                Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                Response.AddHeader("Pragma", "no-cache");
            }
            if (!IsPostBack)
            {
                ProPicIcon();
            }
            


        }
        public void ProPicIcon()
        {
            if (Session["Director"] != null)
            {

                DirMng_Obj.DirProp_Obj.DirEmail = Session["Director"].ToString();
                string result = DirMng_Obj.UserPropic();
                if (result == "-1")
                {
                    ImgProPicIcon.ImageUrl = "~/ActorPages/ActorProPics/usercommon.png";

                }
                else
                {

                    ImgProPicIcon.ImageUrl = result;
                }


            }


        }

        protected void BtnLogOutMaster_Click(object sender, EventArgs e)
        {
            if (Session["Director"] != null)
            {
                Session.Abandon();
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");

            }
            
        }
    }
}