using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Actor.ActorManager;

namespace Online_Film_Casting_Portal.ActorPages
{
    public partial class ActorMaster : System.Web.UI.MasterPage
    {
        ActorManager ActorMng_Obj = new ActorManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Actor"] == null)
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
                ProPicIconNAccType();

            }
          
        }
        public void ProPicIconNAccType()
        {
            if (Session["Actor"]!=null)
            {
                
                ActorMng_Obj.RegProp_Obj.ActorEmail= Session["Actor"].ToString();
                ActorMng_Obj.ActProPicNAccType();
                if (ActorMng_Obj.RegProp_Obj.ProPicActor==null)
                {
                    IMapProPic.ImageUrl = "~/ActorPages/ActorProPics/usercommon.png";

                }
                else
                {
                    
                    IMapProPic.ImageUrl = ActorMng_Obj.RegProp_Obj.ProPicActor;
                }
                if (ActorMng_Obj.RegProp_Obj.AccType == "Normal")
                {
                    BtnPremium.Visible = true;
                   
                }
                else
                {
                    BtnPremium.Visible = false;


                }


            }
            

        }

        protected void BtnLogOutMaster_Click(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                Session.Abandon();
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
        }

        protected void BtnPremium_Click(object sender, EventArgs e)
        {
            if (Session["Actor"] != null)
            {
                Response.Redirect("~/ActorPages/GetPremium.aspx");
            }
            else
            {
                Response.Redirect("~/HomePage/LoginForm.aspx");
            }
        }
    }
}