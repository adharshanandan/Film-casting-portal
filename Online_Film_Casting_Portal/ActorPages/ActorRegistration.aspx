<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="ActorRegistration.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.ActorRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="h-100 bg-dark">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col">
        <div class="card card-registration my-4">
          <div class="row g-0">
            <div class="col-xl-6 d-none d-xl-block">
              <img src="Lal.jpg"
                alt="Sample photo" class="img-fluid"
                style="border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;" />
            </div>
            <div class="col-xl-6">
              <div class="card-body p-md-5 text-black">
                <h3 class="mb-5 text-center text-uppercase">Actor's Registration Form</h3>

                <div class="row">
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                        <asp:TextBox ID="txtFnameActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                      <label class="form-label" for="form3Example1m">First name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvFname" runat="server" ControlToValidate="txtFnameActor" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                  </div>
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                       <asp:TextBox ID="txtLnameActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                      <label class="form-label" for="form3Example1n">Last name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvFname0" runat="server" ControlToValidate="txtLnameActor" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                  </div>
                </div>


                <div class="d-md-flex justify-content-start align-items-center mb-4 py-2">

                  <h6>Gender: </h6>

                  <div class="form-check form-check-inline">
                      &nbsp;<asp:RadioButtonList ID="RbGender" runat="server" CellPadding="10" RepeatDirection="Horizontal">
                          <asp:ListItem>Male</asp:ListItem>
                          <asp:ListItem>Female</asp:ListItem>
                          <asp:ListItem>Other</asp:ListItem>
                      </asp:RadioButtonList>
                  </div>
                    <asp:RequiredFieldValidator ID="RfvGenderActor"  runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="RbGender"></asp:RequiredFieldValidator>

                </div>

                <div class="row">
                  <div class="col-md-4 mb-4">
                      <asp:DropDownList ID="DdCtryActor" runat="server">
                          <asp:ListItem>India</asp:ListItem>
                          
                      </asp:DropDownList>
                  </div>
                  <div class="col-md-4 mb-4">
                    <asp:DropDownList ID="DdStateActor" runat="server">                     
                          <asp:ListItem>Kerala</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                    <div class="col-md-4 mb-4">
                    <asp:DropDownList ID="DdDistActor" runat="server">                     
                         <asp:ListItem>Alappuzha</asp:ListItem>
                        <asp:ListItem>Ernakulam</asp:ListItem>
                        <asp:ListItem>Idukki</asp:ListItem>
                        <asp:ListItem>Kannur</asp:ListItem>
                        <asp:ListItem>Kasaragod</asp:ListItem>
                        <asp:ListItem>Kollam</asp:ListItem>
                        <asp:ListItem>Kottayam</asp:ListItem>
                        <asp:ListItem>Kozhikode</asp:ListItem>
                        <asp:ListItem>Malappuram</asp:ListItem>
                        <asp:ListItem>Palakkad</asp:ListItem>
                        <asp:ListItem>Pathanamthitta</asp:ListItem>
                        <asp:ListItem>Thiruvananthapuram</asp:ListItem>
                        <asp:ListItem>Thrissur</asp:ListItem>
                        <asp:ListItem>Wayanad</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                </div>
                

                <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtDobActor" TextMode="Date" placeholder="dd-mm-yyyy" class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" for="form3Example9">Date of Birth</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvDob" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtDobActor"></asp:RequiredFieldValidator>
                </div>

                <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtAddressActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Address</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvAddress" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtAddressActor"></asp:RequiredFieldValidator>
                </div>

                   <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtZipActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Zip Code</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvZip" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtZipActor"></asp:RequiredFieldValidator>
                </div>

                    <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtPhActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Phone Number</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPh" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtPhActor"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RevPh" runat="server" ControlToValidate="TxtPhActor" ErrorMessage="Only 10 digits are allowed!!" ForeColor="Red" ValidationExpression="^[0-9]{10}$"></asp:RegularExpressionValidator>
                </div>

          
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>



     <section class="h-100 bg-dark">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col">
        <div class="card card-registration my-4">
            <div class="row g-0">
           
            <div class="col-xl-6">
              <div class="card-body p-md-5 text-black">

                     <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtPrevWrks" class="form-control form-control-lg" placeholder="Add description or youtube link etc." runat="server"></asp:TextBox>
                    <label class="form-label" for="form3Example9">Previous Works (if any)</label>
                </div>

                     <div class="form-outline mb-4">
                         <asp:FileUpload ID="FuPropicActor" class="form-control form-control-lg" runat="server" ViewStateMode="Enabled" />
                    <label class="form-label" for="form3Example9">Profile Picture </label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPropic" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="FuPropicActor"></asp:RequiredFieldValidator>
                </div>
               

                <div class="row">
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        
                        <asp:DropDownList ID="DDActExp" runat="server" ToolTip="Select Your Experience">
                 

                          <asp:ListItem>New Face</asp:ListItem>
                            <asp:ListItem>Experienced</asp:ListItem>
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <asp:DropDownList ID="DDMTongue" runat="server" ToolTip="Select your Mother Tongue">
                           
                          <asp:ListItem>Malayalam</asp:ListItem>
                           
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                     <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <asp:DropDownList ID="DDBodyStruct" runat="server" ToolTip="Select Your Body Type">
                    
                          <asp:ListItem>Fat</asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Lean</asp:ListItem>
                           
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                </div>

                  <div class="row">
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        
                        <asp:DropDownList ID="DDSkinCol" runat="server" ToolTip="Select Your Skin Tone">
                            

                          <asp:ListItem>Light</asp:ListItem>
                            <asp:ListItem>Fair</asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Deep</asp:ListItem>
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <asp:DropDownList ID="DDHairCol" runat="server" ToolTip="Select Your Hair Color">
                            
                          <asp:ListItem>Black</asp:ListItem>
                            <asp:ListItem>Brown</asp:ListItem>
                            <asp:ListItem>Blond</asp:ListItem>
                            <asp:ListItem>Gray</asp:ListItem>
                           
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                      <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <asp:DropDownList ID="DDEyeCol" runat="server" ToolTip="Select Your Eye Color">
                            
                          <asp:ListItem>Blue</asp:ListItem>
                             <asp:ListItem>Brown</asp:ListItem>
                             <asp:ListItem>Hazel</asp:ListItem>
                             <asp:ListItem>Gray</asp:ListItem>
                             <asp:ListItem>Amber</asp:ListItem>
                           
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                </div>

                   <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtHeight" placeholder="in cm." class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Height</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvHeight" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtHeight"></asp:RequiredFieldValidator>
  
                </div>


             

                <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtEmail" class="form-control form-control-lg" runat="server" OnTextChanged="TxtEmail_TextChanged" AutoPostBack="true"></asp:TextBox>
                   
                  <label class="form-label" for="form3Example97">Email ID</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvEmail" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtEmail"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RevPh0" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Enter valid Email Id !!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                     <asp:LinkButton ID="LbEmailVerify" runat="server" ForeColor="#0000CC" OnClick="LbEmailVerify_Click" Visible="False" CausesValidation="false">Click here to verify</asp:LinkButton>
                </div>
                   <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtVerifyCode"  class="form-control form-control-lg w-50" placeholder="Enter verification code here" runat="server" Visible="False" OnTextChanged="TxtVerifyCode_TextChanged" AutoPostBack="true"></asp:TextBox>
                  &nbsp;
                   
                       <asp:Label ID="LabCodeMsg" runat="server"></asp:Label>
                   
  
                </div>



                   <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtPswd" TextMode="Password" ToolTip="- contains at least 8 characters &#013;- contains at least one digit &#013;- contains at least one special character" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Password</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPswd" runat="server" ErrorMessage="Required!!"  ForeColor="Red" ControlToValidate="TxtPswd"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RevPh1" runat="server" ControlToValidate="TxtPswd"  ErrorMessage="Please follow password format" ForeColor="Red" ValidationExpression="^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$"></asp:RegularExpressionValidator>
                </div>
                  <div class="ms-auto">
                  <asp:Label ID="LabPswdDes" runat="server" Text="- contains at least 8 characters" ForeColor="Red"></asp:Label><br />
                  <asp:Label ID="Label1" runat="server" Text="- contains at least one digit" ForeColor="Red"></asp:Label><br />
                  <asp:Label ID="Label2" runat="server" Text="- contains at least one special character" ForeColor="Red"></asp:Label>
                      </div>
                    <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtCPswd" TextMode="Password" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Confirm Password</label>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvCPswd" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtCPswd"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CompareValidator ID="CvPswd" runat="server" ControlToCompare="TxtPswd" ControlToValidate="TxtCPswd" ErrorMessage="Password mismatch!!!" ForeColor="Red"></asp:CompareValidator>
                        <br />
                        <asp:CheckBox ID="CbTerms" runat="server" Text="I accept the terms ad conditions." />
&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LabTerms" runat="server" ForeColor="Red"></asp:Label>
                </div>
                      <div class="d-flex justify-content-end pt-3 ">
                    <div class=" mx-auto">
                        <asp:Button ID="BtnFormReset" class="btn btn-danger btn-lg" runat="server" CausesValidation="false" Text="Reset all" OnClick="BtnFormReset_Click" />

                    </div>
                    <div class=" mx-auto">
                        <asp:Button ID="BtnFormSubmit" class="btn btn-success btn-lg" runat="server" Text="Submit Form" OnClick="BtnFormSubmit_Click" />
                    </div>
                    </div>
                    <div class="form-outline mb-4">                
                        <asp:Label ID="LabMsgRegDir" class="form-label" runat="server" Text=""></asp:Label>
                  &nbsp;<asp:LinkButton ID="LbLogin" runat="server" PostBackUrl="~/HomePage/HomePage.aspx" Visible="False">Login</asp:LinkButton>
&nbsp;</div>
                  </div>
                </div>
         
                  <div class="col-xl-6 d-none d-xl-block">
              <img src="Mammootty.jpg"
                alt="Sample photo" class="img-fluid"
                style="border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;" />
            </div>

              </div>
                </div>
              </div>
                </div>

          </div>

</section>
    </asp:Content>

      

