<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Online_Film_Casting_Portal.HomePage.LoginForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">       
        .bodycont
        {
            background-image:url("darkvig.jpg");
          
        }
    </style>
   <%-- <script type="text/javascript">
        window.history.forward();
        function noBack() {
            window.history.forward();
        }

    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
        <div class="card mt-5 p-5 mx-auto bg-light" style="width: 35rem;">
            <div action="#" class="d-flex flex-column mx-auto">
                
                <asp:Image ID="ImgUserIcon" CssClass="mx-auto mb-4" runat="server" Height="136px" ImageUrl="~/ActorPages/ActorProPics/usercommon.png" Width="138px" />
              
                <div class="d-flex input-field  mt-3">        
                    <span class="far fa-user p-2"></span>
                    <asp:TextBox ID="TxtUsername" runat="server" placeholder="Email" class=" form-control w-100"></asp:TextBox>            
                </div>
                <div class="mb-4">
                    <asp:RequiredFieldValidator ID="RfvLoginUName" runat="server" ControlToValidate="TxtUsername" ErrorMessage="Please Enter Username!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                
                
                <div class="d-flex align-items-center input-field">                    
                    <span class="fas fa-lock p-2"></span>                  
                     <asp:TextBox ID="TxtPassword" TextMode="Password" runat="server" placeholder="Password" class=" form-control w-100"></asp:TextBox>
                </div>
                 <div class="mb-4">
                    <asp:RequiredFieldValidator ID="RfvLoginPswd" runat="server" ControlToValidate="TxtPassword" ErrorMessage="Please Enter the Password!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                
                   <div class="col-md-4 mb-4 mx-auto">
                    <asp:DropDownList ID="DdRoles" runat="server">  
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Actor</asp:ListItem>
                        <asp:ListItem>Director</asp:ListItem>
                        
                        
                        
                    </asp:DropDownList>
                       <asp:Label  ID="LabMsg" runat="server" Text=""></asp:Label>
                </div>
                </div>
                <div class="d-sm-flex justify-content-sm-between mx-auto">
                   
                    <asp:LinkButton ID="LbFPswd" class="mt-sm-0 mt-3" runat="server" CausesValidation="false" OnClick="LbFPswd_Click">Forgot password?</asp:LinkButton>
                </div>
                <div class="my-3 mx-auto">
                    <asp:Button ID="BtnLoginMain" runat="server" class="btn btn-primary" Text="Login" OnClick="BtnLoginMain_Click" />
                </div>
                <div class="mb-3 mx-auto">
                    <span class="text-light-white">Don't have an account?</span>                    
                    <asp:LinkButton ID="LbSignup" runat="server" OnClick="LbSignup_Click" CausesValidation="false">Sign Up</asp:LinkButton>
                </div>
            
             
            
            <div class="position-relative border-bottom my-3 line mx-auto">
                <span class="connect">or connect with</span>
            </div>
            <section class="d-flex justify-content-center justify-content-lg-between p-4 border-bottom">

    <div class="mx-auto">
     <a href="#" class="me-4 link-secondary">
        <i class="fab fa-facebook-f"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-twitter"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-google"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-instagram"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-linkedin"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-github"></i>
      </a>
 
    </div>
  
  </section>
            </div>
        </div>
        
  
   <br />
    <br />
    <br />
    <br />

    
</asp:Content>
