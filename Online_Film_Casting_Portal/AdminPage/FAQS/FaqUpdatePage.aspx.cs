using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace Online_Film_Casting_Portal.AdminPage
{
    public partial class FaqUpdatePage : System.Web.UI.Page
    {
        AdminManager Adm_obj = new AdminManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] != null)
                {
                    FaqBind();
                }
                else
                {
                    Response.Redirect("~/HomePage/LoginForm.aspx");
                }
                
            }

        }
        public void FaqBind()
        {
            GvFaq.DataSource = Adm_obj.SelectAllData("SelectAllFaqs");
            GvFaq.DataBind();
        }

        public void FaqDelete(String SelId)
        {
            Adm_obj.FaqProp_Obj.Id = Convert.ToInt32(SelId);
            string result;
            result = Adm_obj.DeleteFromFaq("FaqDelete");
            LabelMessage(result);
        

        }

        protected void ImgBtnFaqDelete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imgBtn = sender as ImageButton;
            GridViewRow gvr = imgBtn.NamingContainer as GridViewRow;
            FaqDelete(GvFaq.DataKeys[gvr.RowIndex].Value.ToString());
            


        }

        protected void BtnAddFaq_Click(object sender, EventArgs e)
        {
            Adm_obj.FaqProp_Obj.Question = TxtFaqQn.Text.ToString();
            Adm_obj.FaqProp_Obj.Answer = TxtFaqAns.Text.ToString();
            string result = Adm_obj.InsertFaqs("FaqInsert");
            LabelMessage(result);

        }

        public void LabelMessage(string result)
        {
            if (result == "Error!")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "Error Occured";
            }
            else if (result == "Success")
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Green;
                LabMsg.Text = "Success";
                FaqBind();

            }
            else
            {
                LabMsg.Visible = true;
                LabMsg.ForeColor = System.Drawing.Color.Red;
                LabMsg.Text = "Failed due to some technical errors!";
            }

        }

        protected void BtnClrFaq_Click(object sender, EventArgs e)
        {
            TxtFaqAns.Text = "";
            TxtFaqQn.Text = "";
        }
    }
}