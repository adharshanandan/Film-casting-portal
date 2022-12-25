using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Visitor;

namespace Online_Film_Casting_Portal.HomePage
{
    public partial class ContactUs : System.Web.UI.Page
    {
        VisitorsManager VisMng_Obj = new VisitorsManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            VisMng_Obj.VisProp_Obj.CusName = TxtFName.Text.ToString().Trim() + " " + TxtLName.Text.ToString().Trim();
            VisMng_Obj.VisProp_Obj.CusEmail = TxtEmail.Text.ToString();
            VisMng_Obj.VisProp_Obj.CusMessage = TxtMsg.Text.ToString().Trim();
            string result = VisMng_Obj.InstertVisitorsMsg();
            if (result == "Error")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "Sorry for the inconvenience.Please try after sometime";
                ClearAll();

            }
            if (result == "Success")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Green;
                LabMsg.Text = "Thank you for the inquiry. We will contact you soon";
                ClearAll();

            }
            else
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "Technical issue!! Sorry for the inconvenience.Please try after sometime";
                ClearAll();

            }


        }

        protected void BtnClr_Click(object sender, EventArgs e)
        {
            LabMsg.Text = "";
            ClearAll();
        }
        public void ClearAll()
        {
            TxtFName.Text = "";
            TxtLName.Text = "";
            TxtEmail.Text = "";
            TxtMsg.Text = "";
           
        }

        
    }
}