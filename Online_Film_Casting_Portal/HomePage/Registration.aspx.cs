using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Film_Casting_Portal.HomePage
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDirector_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DirectorPage/DirectorRegistration.aspx");
        }

        protected void btnActor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ActorPages/ActorRegistration.aspx");
        }
    }
}