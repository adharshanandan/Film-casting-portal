using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;
using System.Collections;

namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class UpdateCalls : System.Web.UI.Page
    {
        CastingCallManager CastMng_Obj = new CastingCallManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CastingDetailsBind();
            }
        }
        public void CastingDetailsBind()
        {
            if (Session["Director"] != null)
            {
                CastMng_Obj.CastProp_Obj.DirEmail = Session["Director"].ToString();
                GvCasting.DataSource = CastMng_Obj.CastingDetailsByDirId();
                GvCasting.DataBind();

            }
            
        }

        protected void GvCasting_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && GvCasting.EditIndex==e.Row.RowIndex)
            {
                DropDownList DDNoAct = (DropDownList) e.Row.FindControl("DDNoOfAct") ;
                DropDownList DDAgeFrom = (DropDownList)e.Row.FindControl("DDAgeFrom");
                DropDownList DDAgeTo = (DropDownList)e.Row.FindControl("DDAgeTo");
                
                DDNoAct.DataSource = DDBind(50);
                DDNoAct.DataBind();
                DDAgeFrom.DataSource= DDBind(80);
                DDAgeFrom.DataBind();
                DDAgeTo.DataSource = DDBind(80);
                DDAgeTo.DataBind();

                ArrayList DDBind(int Range)
                {
                    ArrayList ArrBind = new ArrayList();
                    int count = 1;
                    for (int i = 0; i < Range; ++i)
                    {
                        ArrBind.Add(count);
                        count++;
                    }
                    return ArrBind;

                }
                
                
            }
        }

        protected void GvCasting_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvCasting.EditIndex = e.NewEditIndex;
            CastingDetailsBind();
        }

        protected void GvCasting_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvCasting.EditIndex = -1;
            CastingDetailsBind();
        }

        protected void GvCasting_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvCasting.PageIndex = e.NewPageIndex;
            CastingDetailsBind();

        }

        protected void GvCasting_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label CastId = (Label)GvCasting.Rows[e.RowIndex].FindControl("LabCastId");
            CastMng_Obj.CastProp_Obj.CastId = Convert.ToInt32(CastId.Text);
            string result=CastMng_Obj.CastingCallDelete();
            if (result == "Error")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Could not be deleted')", true);
            }
            else if (result == "Success")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Deleted successfully')", true);
                CastingDetailsBind();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Detele failed due to technical issues.')", true);
            }
        }

        protected void GvCasting_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label LabCastId = (Label)GvCasting.Rows[e.RowIndex].FindControl("LabCastId");
            TextBox TxtProComp = (TextBox)GvCasting.Rows[e.RowIndex].FindControl("TxtProComp");
            TextBox TxtMName= (TextBox)GvCasting.Rows[e.RowIndex].FindControl("TxtMName");
            DropDownList DDGender=(DropDownList)GvCasting.Rows[e.RowIndex].FindControl("DDGender");
            DropDownList DDNoOfAct = (DropDownList)GvCasting.Rows[e.RowIndex].FindControl("DDNoOfAct");
            DropDownList DDAgeFrom = (DropDownList)GvCasting.Rows[e.RowIndex].FindControl("DDAgeFrom");
            DropDownList DDAgeTo = (DropDownList)GvCasting.Rows[e.RowIndex].FindControl("DDAgeTo");
            TextBox TxtCharDesc = (TextBox)GvCasting.Rows[e.RowIndex].FindControl("TxtCharDesc");
            DropDownList DDExp = (DropDownList)GvCasting.Rows[e.RowIndex].FindControl("DDExp");
            DropDownList DDLang = (DropDownList)GvCasting.Rows[e.RowIndex].FindControl("DDLang");
           
            TextBox TxtLDate = (TextBox)GvCasting.Rows[e.RowIndex].FindControl("TxtLDate");

            CastMng_Obj.CastProp_Obj.CastId = Convert.ToInt32(LabCastId.Text);
            CastMng_Obj.CastProp_Obj.ProductionName = TxtProComp.Text;
            CastMng_Obj.CastProp_Obj.MovieName = TxtMName.Text;
            CastMng_Obj.CastProp_Obj.PreGender = DDGender.SelectedValue;
            CastMng_Obj.CastProp_Obj.NoOfActors = Convert.ToInt32(DDNoOfAct.SelectedValue);
            CastMng_Obj.CastProp_Obj.AgeFrom = Convert.ToInt32(DDAgeFrom.SelectedValue);
            CastMng_Obj.CastProp_Obj.AgeTo = Convert.ToInt32(DDAgeTo.SelectedValue);
            CastMng_Obj.CastProp_Obj.CharacterDiscription = TxtCharDesc.Text;
            CastMng_Obj.CastProp_Obj.PreExperience = DDExp.SelectedValue;
            CastMng_Obj.CastProp_Obj.MovieLanguage = DDLang.SelectedValue;
           
            CastMng_Obj.CastProp_Obj.LastDate = Convert.ToDateTime(TxtLDate.Text);

            string result = CastMng_Obj.UpdateCastingCall();
            if (result == "Error")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Could not be updated')", true);
            }
            if (result == "Success")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Updated successfully')", true);
                GvCasting.EditIndex = -1;
                CastingDetailsBind();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Update failed due to technical issues.')", true);
            }

        }
    }
}