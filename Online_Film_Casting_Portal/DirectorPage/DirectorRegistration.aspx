<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="DirectorRegistration.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.DirectorRegistration" %>
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
              <img src="Images/film.jpg"
                alt="Sample photo" class="img-fluid"
                style="border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;" />
            </div>
            <div class="col-xl-6">
              <div class="card-body p-md-5 text-black">
                <h3 class="mb-5 text-uppercase text-center">Director's Registration Form</h3>

                <div class="row">
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                        <asp:TextBox ID="txtFnameDir" class="form-control form-control-lg" runat="server"></asp:TextBox>
                      <label class="form-label" for="form3Example1m">First name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvFName" runat="server" ControlToValidate="txtFnameDir" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;</div>
                  </div>
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                       <asp:TextBox ID="txtLnameDir" class="form-control form-control-lg" runat="server"></asp:TextBox>
                      <label class="form-label" for="form3Example1n">Last name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvLName" runat="server" ControlToValidate="txtLnameDir" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                  </div>
                </div>


                <div class="d-md-flex justify-content-start align-items-center mb-4 py-2">

                  <h6 class="mb-0 me-4">Gender: </h6>

                  <div class="form-check form-check-inline p-1 ">
                      <asp:RadioButtonList ID="RbGender" runat="server"  RepeatDirection="Horizontal">
                          <asp:ListItem style="margin-left:10px;margin-right:1px">Male</asp:ListItem>
                          <asp:ListItem style="margin-left:10px;margin-right:1px">Female</asp:ListItem>
                          <asp:ListItem style="margin-left:10px;margin-right:1px">Other</asp:ListItem>
                      </asp:RadioButtonList>
                  
                  </div> <asp:RequiredFieldValidator ID="RfvGender" runat="server" ErrorMessage="Required!!" ControlToValidate="RbGender" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>

                <div class="row">
                  <div class="col-md-4 mb-4">
                      <asp:DropDownList ID="DdCtryDir" runat="server">
                          <asp:ListItem>India</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="col-md-4 mb-4">
                    <asp:DropDownList ID="DdStateDir" runat="server">                     
                          <asp:ListItem>Kerala</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                    <div class="col-md-4 mb-4">
                    <asp:DropDownList ID="DdDistDir" runat="server">                     
                          <asp:ListItem>Alappuzha</asp:ListItem>
                         <asp:ListItem>	Ernakulam</asp:ListItem>
                         <asp:ListItem>	Idukki</asp:ListItem>
                         <asp:ListItem>	Kannur</asp:ListItem>
                         <asp:ListItem>	Kasaragod</asp:ListItem>
                         <asp:ListItem>	Kollam</asp:ListItem>
                         <asp:ListItem>	Kottayam</asp:ListItem>
                         <asp:ListItem>	Kottayam</asp:ListItem>
                         <asp:ListItem>	Malappuram</asp:ListItem>
                         <asp:ListItem>	Palakkad</asp:ListItem>
                         <asp:ListItem>	Pathanamthitta</asp:ListItem>
                         <asp:ListItem>Thiruvananthapuram</asp:ListItem>
                         <asp:ListItem>Thrissur</asp:ListItem>
                         <asp:ListItem>Wayanad</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                   
                </div>
                   <div class="col-md-3 mb-4">
                      <asp:DropDownList ID="DdFilmInd" runat="server">
                          <asp:ListItem>Malayalam</asp:ListItem>
                          <asp:ListItem>Tamil</asp:ListItem>
                      </asp:DropDownList>
                  </div>

                <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtDobDir" TextMode="Date" placeholder="dd-mm-yyyy" class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" for="form3Example9">Date of Birth</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvDob" runat="server" ControlToValidate="TxtDobDir" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                   <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtMembId" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Membership ID</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvMemId" runat="server" ControlToValidate="TxtMembId" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;</div>
                  <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtAddress" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" >Address</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvAddress" runat="server" ControlToValidate="TxtAddress" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;</div>
                  <div class="form-outline mb-4">
                         <asp:FileUpload ID="FuPropicDir" class="form-control form-control-lg" runat="server" ViewStateMode="Enabled" />
                    <label class="form-label" >Profile Picture </label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPropic" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="FuPropicDir"></asp:RequiredFieldValidator>
                </div>
                   <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtPh" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" >Phone Number</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvPh" runat="server" ControlToValidate="TxtPh" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:RegularExpressionValidator ID="RfvPhone" runat="server" ControlToValidate="TxtPh" ErrorMessage="Only 10 digits are allowed!!" ForeColor="Red" ValidationExpression="^[0-9]{10}$"></asp:RegularExpressionValidator>
                    &nbsp;</div>

                <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtEmailDir" class="form-control form-control-lg" runat="server" OnTextChanged="TxtEmailDir_TextChanged" AutoPostBack="true"></asp:TextBox>
                  <label class="form-label" >Email ID</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvEmail" runat="server" ControlToValidate="TxtEmailDir" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LbEmailVerify" runat="server" ForeColor="Blue" OnClick="LbEmailVerify_Click1" CausesValidation="false" Visible="False">Click here to verify</asp:LinkButton>
&nbsp;</div>

                  <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtVerifyCode" class="form-control form-control-lg w-50" runat="server" OnTextChanged="TxtVerifyCode_TextChanged" placeholder="Enter your verification code here." AutoPostBack="true" Visible="False"></asp:TextBox>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvVerCode" runat="server" ControlToValidate="TxtVerifyCode" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="LabCodeMsg" runat="server"></asp:Label>
                </div>

                   <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtPswdDir" TextMode="Password" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" >Password</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvPswd" runat="server" ControlToValidate="TxtPswdDir" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>

                    </div>
                  <div class="form-outline mb-4">
                  <asp:Label ID="LabPswdDes" runat="server" Text="- contains at least 8 characters" ForeColor="Red"></asp:Label><br />
                  <asp:Label ID="Label1" runat="server" Text="- contains at least one digit" ForeColor="Red"></asp:Label><br />
                  <asp:Label ID="Label2" runat="server" Text="- contains at least one special character" ForeColor="Red"></asp:Label>
                      </div>

                  
                  

                    <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtCPswdDir" TextMode="Password" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" >Confirm Password</label>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvCPswd" runat="server" ControlToValidate="TxtCPswdDir" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CompareValidator ID="CvPswd" runat="server" ControlToCompare="TxtPswdDir" ControlToValidate="TxtCPswdDir" ErrorMessage="Password mismatch!!" ForeColor="Red"></asp:CompareValidator>
                    &nbsp;<br />
                  </div>
                   <div class="mb-4">                
                   
                       <asp:CheckBox class="form-check" style="padding:10px" ID="CbTerms" runat="server" Text="    I agree to terms and conditions" Font-Size="Medium" Font-Strikeout="False" />
                    &nbsp;<br />
                       <asp:Label ID="LabMsgRegDir" runat="server"></asp:Label>
                       <br />
                  </div>

                <div class="d-flex justify-content-end pt-3">
                    <div class="p-2">
                        <asp:Button ID="BtnSubmit" class="btn btn-success btn-lg" runat="server" Text="Submit Form" OnClick="BtnSubmit_Click" />
                    </div>
                    <div class="p-2">
                        <asp:Button ID="BtnReset" class="btn btn-danger btn-lg" runat="server" CausesValidation="false" Text="Reset all" OnClick="BtnReset_Click" />

                    </div>
                    
                    </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
</asp:Content>
