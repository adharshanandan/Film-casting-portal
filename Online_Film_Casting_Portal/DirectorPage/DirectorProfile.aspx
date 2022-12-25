<%@ Page Title="" Language="C#" MasterPageFile="~/DirectorPage/DirectorMaster.Master" AutoEventWireup="true" CodeBehind="DirectorProfile.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.DirectorProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
        <section>
  <div class="container mx-auto m-3 p-5 py-5">
  

    <div class="row">
      <div class="col-lg-12">
        <div class="card mb-4">
          <div class="card-body text-center bg-light">
              <div class="mb-3 mt-3">
                  
                
              <asp:ImageMap ID="ImgMapProfilePic" class="rounded-circle img-fluid" runat="server" Height="221px" Width="221px"></asp:ImageMap>
                  </div>
              <asp:Label class="my-3" style="font-size:25px" ID="LabName" runat="server" Text=""></asp:Label>
              <br />
              <asp:Label class="text-muted mb-3" style="font-size:15px" ID="LabPlace" runat="server" Text=""></asp:Label>
            
            <div class="d-flex justify-content-center mb-2 mt-4">
              
                <asp:Button ID="BtnEdit" class="btn btn-primary m-3" runat="server" Text="Edit Profile" OnClick="BtnEdit_Click"   />                           
            </div>
          </div>
        </div>
        </div>
      </div>
      <div class="row">
      <div class="col-lg-12 mx-auto">
        <div class="card mb-4">
          <div class="card-body">
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Id </p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabId" runat="server" Text=""></asp:Label>  
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Gender </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabGender" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Date of Birth </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabDob" runat="server" Text=""></asp:Label>
              </div>
            </div>
               <hr>
   
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Address </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabAddress" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Membership Id </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabMemId" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Mobile </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabPh" runat="server" Text=""></asp:Label>
              </div>
            </div> 
              <hr />
              <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Nationality </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabCntry" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr />
              <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Film Industry</p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabFilmInd" runat="server" Text=""></asp:Label>  
              </div>
            </div>
           
          
            </div>
          </div>
        </div>


           
            
           
            
           
          </div>
    </div>
   
</section>
</asp:Content>
