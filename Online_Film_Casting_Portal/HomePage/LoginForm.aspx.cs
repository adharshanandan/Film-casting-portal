using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace Online_Film_Casting_Portal.HomePage
{
    public partial class LoginForm : System.Web.UI.Page
    {
        private LoginManager Login_Obj = new LoginManager();
        SortedList<string, string> S1 = new SortedList<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Status"] != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Registered successfully. Please Login.')", true);
                    Session.Abandon();

                }
               
               
            }
            
        }

        protected void BtnLoginMain_Click(object sender, EventArgs e)
        {
            
            if (DdRoles.SelectedValue == "Admin")
            {
                Session["Admin"] = TxtUsername.Text;
                string query = "select AdminUsername,AdminPassword from AdminDetails";
                S1.Clear();
                S1 = Login_Obj.GetCredential(query);
                string UName = S1.Keys[0].ToString();
                string Pwsd = S1[UName];

                if(UName==TxtUsername.Text && Pwsd==TxtPassword.Text)
                {
                    Response.Redirect("~/AdminPage/VisitorMessage.aspx");
                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.Text = "Invalid Credentials!!";
                }
            }
            else if (DdRoles.SelectedValue == "Actor")
            {
                Session["Actor"] = TxtUsername.Text.Trim();
                S1.Clear();
                string query = "select ActorEmail,ActorPswd from ActorDetails where ActorEmail='"+TxtUsername.Text+"'";
                S1 = Login_Obj.GetCredential(query);
                if (S1.Count!=0)
                {
                    string AUname = S1.Keys[0].ToString();
                    string APswd = S1.Values[0].ToString();
                    if (AUname == TxtUsername.Text && APswd == TxtPassword.Text)
                    {
                        Response.Redirect("~/ActorPages/ActorProfile.aspx");
                    }
                    else
                    {
                        LabMsg.Visible = true;
                        LabMsg.ForeColor = System.Drawing.Color.Red;
                        
                        LabMsg.Text = "Invalid Credentials!!";
                    }

                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.ForeColor = System.Drawing.Color.Red;
                    
                    LabMsg.Text = "User not found";
                }
                

            }

            else if (DdRoles.SelectedValue == "Director")
            {
                Session["Director"] = TxtUsername.Text.Trim();
                S1.Clear();
                string query = "select DirEmail,DirPassword from DirectorDetails where DirEmail='" + TxtUsername.Text + "'";
                S1 = Login_Obj.GetCredential(query);
                if (S1.Count != 0)
                {
                    string DUname = S1.Keys[0].ToString();
                    string DPswd = S1.Values[0].ToString();
                    if (DUname == TxtUsername.Text && DPswd == TxtPassword.Text)
                    {
                        Response.Redirect("~/DirectorPage/DirectorProfile.aspx");
                    }
                    else
                    {
                        LabMsg.Visible = true;
                        LabMsg.ForeColor = System.Drawing.Color.Red;

                        LabMsg.Text = "Invalid Credentials!!";
                    }

                }
                else
                {
                    LabMsg.Visible = true;
                    LabMsg.ForeColor = System.Drawing.Color.Red;

                    LabMsg.Text = "User not found";
                }


            }



        }

        protected void LbSignup_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/HomePage/Registration.aspx");
        }

        protected void LbFPswd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage/ForgotPassword.aspx");
        }
    }
}