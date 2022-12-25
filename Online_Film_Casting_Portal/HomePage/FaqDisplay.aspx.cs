using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace Online_Film_Casting_Portal.HomePage
{
    public partial class FaqDisplay : System.Web.UI.Page
    {
        AdminManager AdmMng_Obj = new AdminManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            FaqsBind();
        }

        // Function to bind faq table from database
        public void FaqsBind()
        {
            DlFaqs.DataSource = AdmMng_Obj.DisplayFaqs();
            DlFaqs.DataBind();
        }

        
        protected void BtnFindQns_ServerClick(object sender, EventArgs e)
        {
            if (TxtFindQn.Text != "")
            {
                AdmMng_Obj.AdmProp_Obj.Question = TxtFindQn.Text;
                // Attach qns matching with given keyword
                DlFaqs.DataSource = AdmMng_Obj.DisplayFaqsbySearch();
                DlFaqs.DataBind();

            }
            else
            {
                FaqsBind();
            }
           

        }

     
    }
}