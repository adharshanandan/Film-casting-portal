using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer.Director.DirectorManager;


namespace Online_Film_Casting_Portal.DirectorPage
{
    public partial class CastingCall : System.Web.UI.Page
    {
        CastingCallManager CastMng_Obj = new CastingCallManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DDAgeBind();
                NoOfActorsBind();
                HeightBind();
                ClearFields();
            }

        }
            
        public void DDAgeBind()
        {
            int[] ArrAge = new int[66];
            int Age = 15;
            for (int i = 0; i < ArrAge.Length; ++i)
            {
                ArrAge[i] = Age;
                Age++;
            }
            DDAgeFrom.DataSource = ArrAge;
            DDAgeFrom.DataBind();
            DDAgeTo.DataSource = ArrAge;
            DDAgeTo.DataBind();
        }
        public void NoOfActorsBind()
        {
            int count = 1;
            int[] ArrCount = new int[50];
            for (int i = 0; i < ArrCount.Length; ++i)
            {
                ArrCount[i] = count;
                count++;
            }
            DDNoOfActors.DataSource = ArrCount;
            DDNoOfActors.DataBind();
        }
        public void HeightBind()
        {
            int Hgt = 100;
            int[] ArrHeight = new int[101];
            for (int i = 0; i < ArrHeight.Length; ++i)
            {
                ArrHeight[i] = Hgt;
                Hgt++;
            }
            DdHeight.DataSource = ArrHeight;
            DdHeight.DataBind();

        }

        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            if (Session["Director"] != null)
            {
                CastMng_Obj.CastProp_Obj.DirEmail = Session["Director"].ToString();               
                CastMng_Obj.CastProp_Obj.PreGender = RbGender.SelectedValue;
                CastMng_Obj.CastProp_Obj.AgeFrom = Convert.ToInt32(DDAgeFrom.SelectedValue);
                CastMng_Obj.CastProp_Obj.AgeTo = Convert.ToInt32(DDAgeTo.SelectedValue);
                CastMng_Obj.CastProp_Obj.PreExperience = DDActExp.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreCountry = DdCtryDir.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreState = DdStateDir.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreDist = DdDistDir.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreSkinCol = DDSkinCol.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreHairCol = DDHairCol.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreEyeCol = DDEyeCol.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreBodyStruct = DDBodyStruct.SelectedValue;
                CastMng_Obj.CastProp_Obj.PreHeight = Convert.ToInt32(DdHeight.SelectedValue);
                CastMng_Obj.CastProp_Obj.CharacterDiscription = TxtCharDesc.Text;
                CastMng_Obj.CastProp_Obj.NoOfActors = Convert.ToInt32(DDNoOfActors.SelectedValue);
                CastMng_Obj.CastProp_Obj.ProductionName = TxtProCpny.Text;
                CastMng_Obj.CastProp_Obj.PostedDate = DateTime.Now;
                CastMng_Obj.CastProp_Obj.LastDate = Convert.ToDateTime(TxtLastDate.Text);
                CastMng_Obj.CastProp_Obj.MovieName = TxtMovieName.Text;
                CastMng_Obj.CastProp_Obj.MovieLanguage = DDMLanguage.SelectedValue;
                string result=CastMng_Obj.CastingCallInsert();
                if (result == "Error")
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Upload failed. Please try after sometime";
                }
                else if (result == "Success")
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Uploaded Successfully')", true);
                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Sorry for the inconvenience. Please try after sometime";

                }

            }


        }

        protected void BtnClr_Click(object sender, EventArgs e)
        {

            ClearFields();
        }

        public void ClearFields()
        {
            RbGender.ClearSelection();
            DDAgeFrom.SelectedIndex = 0;
            DDAgeTo.SelectedIndex = 0;
            DDActExp.SelectedIndex = 0;
            DdCtryDir.SelectedIndex = 0;
            DdStateDir.SelectedIndex = 0;
            DdDistDir.SelectedIndex = 0;
            DDSkinCol.SelectedIndex = 0;
            DDHairCol.SelectedIndex = 0;
            DDEyeCol.SelectedIndex = 0;
            DDBodyStruct.SelectedIndex = 0;
            DdHeight.SelectedIndex = 0;
            TxtCharDesc.Text = "";
            DDNoOfActors.SelectedIndex = 0;
            TxtProCpny.Text = "";
            TxtLastDate.Text = "";
            TxtMovieName.Text = "";
            DDMLanguage.SelectedIndex = 0;
        }
    }
}