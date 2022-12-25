<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Online_Film_Casting_Portal.HomePage.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-light">
        <div class="row">
            <div class="col-md-6">
                <img class="h-100 w-100" src="Contactusimg/Phone.jpg" />
            </div>
            <div class="col-md-6">
                            <div class="mb-2 mt-5">
 
                <label class="form-label">First Name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RequiredFieldValidator ID="RfvFName" runat="server" ControlToValidate="TxtFName" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                 <asp:TextBox ID="TxtFName" class="form-control" runat="server"></asp:TextBox>
            <div class="mb-2">
                <label class="form-label">Last Name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RfvLName" runat="server" ControlToValidate="TxtLName" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:TextBox ID="TxtLName" class="form-control" runat="server"></asp:TextBox>
            </div>
            </div>
   
  
              
             <div class="mb-2">
                   <label class="form-label">Email</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:RequiredFieldValidator ID="RfvEmail" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:RegularExpressionValidator ID="ReEmail" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Enter a valid Email Id!!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
&nbsp;<asp:TextBox ID="TxtEmail" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                    <label class="form-label">Message</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvMsg" runat="server" ControlToValidate="TxtMsg" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="TxtMsg" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

             
                <asp:Button ID="BtnSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
                <asp:Button ID="BtnClr" class="btn btn-danger" runat="server" CausesValidation="false" Text="Clear" OnClick="BtnClr_Click" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="LabMsg" runat="server"></asp:Label>
&nbsp;</div>



            </div>
        </div>



    <section class="bg-dark p-2">
    <div class="container text-white text-center text-md-start">

      <div class="row">

 
        <div class="col-md-4 col-lg-2 col-xl-2 mx-auto mb-4 mt-5">

          <h6 class="text-uppercase fw-bold mb-4">
            Useful links
          </h6>
          <p>
            <a href="HomePage.aspx" class="text-reset">Home</a>
          </p>
          <p>
            <a href="#!" class="text-reset">About Us</a>
          </p>
         
        </div>



        <div class="col-md-6 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4 mt-5">
  
          <h6 class="text-uppercase fw-bold mb-4">Contact</h6>
          <p><i class="fas fa-home me-3 text-secondary"></i> Kerala, India</p>
          <p>
            <i class="fas fa-envelope me-3 text-secondary"></i>
            info@ofcp.com
          </p>
          <p><i class="fas fa-phone me-3 text-secondary"></i>+91 9645207017</p>
   
        </div>

      </div>
    </div>
  </section>
</asp:Content>
