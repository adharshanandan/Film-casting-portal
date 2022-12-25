<%@ Page Title="" Language="C#" MasterPageFile="~/ActorPages/ActorMaster.Master" AutoEventWireup="true" CodeBehind="CastingCallDetails.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.CastingCallDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <section>
  <div class="container mx-auto m-5 p-5 py-5">
  
      <div class="row">
      <div class="col-lg-8 mx-auto">
        <div class="card mb-4 bg-light">
          <div class="card-body p-5">
              <div class="row">
                         <div class="row">
  
              <div class="col-sm-12 fs-2 mb-3 text-center">
                    <asp:Label ID="LabExp" runat="server" Text=""></asp:Label>  
              </div>
            </div>
                 
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
                <p class="mb-0">Number of actors </p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabNoActor" runat="server" Text=""></asp:Label>  
              </div>
            </div>
                      <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Age between </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabAgeBetween" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Preferred Location </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabLoc" runat="server" Text=""></asp:Label>
              </div>
            </div>
               <hr>
   
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Skin-tone </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabSkintone" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Hair Color </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabHairCol" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Eye Color </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabEyeCol" runat="server" Text=""></asp:Label>
              </div>
            </div> 
              <hr />
              <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Body Type </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabBody" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr />
              <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Height up to</p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabHeight" runat="server" Text=""></asp:Label>  
              </div>
            </div>
                 
                <hr />
                      <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Character Description </p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabCharDesc" runat="server" Text=""></asp:Label>  
              </div>
            </div>

                     <hr />
                      <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Posted on </p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabPostedDate" runat="server" Text=""></asp:Label>  
              </div>
            </div>

                       <hr />
                      <div class="row mb-5">
              <div class="col-sm-3">
                <p class="mb-0">Last Date </p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabEndDate" runat="server" Text=""></asp:Label>  
              </div>
            </div>
                  <asp:Label ID="LabMsg" CssClass="mb-3 mt-3" runat="server" Text=""></asp:Label>
                              <div class="row">
         
             
                  <asp:Button ID="BtnApply" CssClass="btn btn-primary mx-auto w-25" runat="server" Text="Apply" OnClick="BtnApply_Click" />
                  <asp:Button ID="BtnBack" CssClass="btn btn-primary mx-auto w-25" runat="server" Text="Back" OnClick="BtnBack_Click" />
              </div>
     
          
           
         
                  

              </div>
            
           
          
            </div>
          </div>
        </div>
          </div>
      </div>
  
</section>
</asp:Content>
