<%@ Page Title="" Language="C#" MasterPageFile="~/ActorPages/ActorMaster.Master" AutoEventWireup="true" CodeBehind="ActorProfile.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.ActorProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
        


        <section>
  <div class="container py-5">
  

    <div class="row">
      <div class="col-lg-12">
        <div class="card mb-4">
          <div class="card-body text-center" style="background-image:url(abstract-luxury-background.jpg);background-size:cover">
              <div class="mb-3">
               
              <asp:ImageMap ID="ImgMapProfilePic" class="rounded-circle img-fluid  mt-5" runat="server" Height="221px" Width="221px"></asp:ImageMap>
                    <div class="col-md-12 align-content-end">
                    <asp:ImageButton CssClass="ms-auto" ID="ImgBadge" Height="70px" Width="70px" runat="server" />  
                </div>  
                  </div>
              <asp:Label class="my-3" style="font-size:25px" ID="LabName" runat="server" Text=""></asp:Label>
              <br />
              <asp:Label class="text-muted mb-3" style="font-size:15px" ID="LabPlace" runat="server" Text=""></asp:Label>
            
            <div class="d-flex justify-content-center mb-2 mt-4">
             <button type="button" id="BtnEdit" runat="server" onserverclick="BtnEdit_ServerClick" class="btn btn-primary m-3"><i class="fas fa-edit"></i> Edit Profile</button>
                   
                 <button type="button" id="BtnUpload" class="btn btn-dark m-3" runat="server" onserverclick="BtnUpload_ServerClick"><i class="fas fa-video"></i> Upload Video</button>
            </div>
              <div class="row align-content-center">
                  <div class="col-md-6 p-0 mx-auto text-center" >
                       <asp:FileUpload CssClass="w-50 mx-auto form-control mt-5" ID="FuVds" runat="server" Visible="False" />
                      <asp:TextBox ID="TxtCap" CssClass="form-control mt-2 mb-2" runat="server" TextMode="MultiLine"></asp:TextBox>

                      <asp:Label ID="LabMsg" runat="server" Text=""></asp:Label>
                  <div class="mt-3 mb-5">
                      <asp:Button ID="BtnUploadVds" CssClass="btn btn-primary " runat="server" Text="Upload" OnClick="BtnUploadVds_Click" />
                  
                  
                      <asp:Button ID="BtnCancel" CssClass="btn btn-danger " runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
                  </div>
                  </div>
              
              </div>
                 
              
          </div>
        </div>
        </div>
      </div>
       <div class="card mb-4">
          <div class="card-body" style="background-color:#F0F0F0">
              <asp:Label ID="LabPInfo" style="font-size:30px;color:#2D033B" runat="server" Text="Personal Informations"></asp:Label>
          <hr />
      <div class="row">
      <div class="col-lg-6 mx-auto">
       
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
                <p class="mb-0">Zip Code </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabZip" runat="server" Text=""></asp:Label>
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
              <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Email </p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabEmail" runat="server" Text=""></asp:Label>
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
           
          
            </div>
          

  <div class="col-lg-6" >
        
         
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Mother Tongue</p>
              </div>
              <div class="col-sm-9">
                    <asp:Label ID="LabMTng" runat="server" Text=""></asp:Label>  
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Experience</p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabExp" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                
                  <asp:Label ID="LabPreworks" class="mb-0" runat="server" Text="Previous Works"></asp:Label>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabPreW" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Height (in cm.)</p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabHeight" runat="server" Text=""></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Skin Tone</p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabSkin" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Hair Color</p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabHair" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr>
              <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Eye Color</p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabEye" runat="server" Text=""></asp:Label>
              </div>
            </div>
              <hr>
              <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Body Type</p>
              </div>
              <div class="col-sm-9">
                <asp:Label ID="LabBody" runat="server" Text=""></asp:Label>
              </div>
            </div>
       
       
    

      </div>
    </div>
              </div>
        </div>




      <div class="card mb-4">
          
     
         
           <div class="card-body" style="background-color:#F7F7F7">
         
          <asp:Label ID="LabTitle" style="font-size:30px;color:#2D033B" runat="server" Text="Videos"></asp:Label>
          <hr />
      <asp:DataList ID="DlVideos" runat="server" DataKeyField="VidId" CellPadding="0" HorizontalAlign="Justify" RepeatDirection="Horizontal" RepeatColumns="4" OnItemCommand="DlVideos_ItemCommand">
          <ItemTemplate>
             
               <div class="row">
                   <div class="col-md-12">
                          

                              <div class="row">
                                  <div class="col-md-12 mx-auto">
                                   <asp:Label ID="LabUDate" style="font-size:15px;color:#2D033B" CssClass="text-muted" runat="server" Text='<%# "Uploaded on : "+Eval("UploadedDate") %>'></asp:Label>
                                      </div>
                                  </div>
                       <div class="row">
                                  <div class="col-md-12 d-flex justify-content-end">
                                      <asp:Button ID="BtnRemove" CommandName="RmvCmd" CssClass="btn btn-light" style="font-size:25px" runat="server" Text="x"/>
                                      <%--<asp:ImageButton ID="ImgBtnRemove" CssClass="fas fa-times" CommandName="RmvCmd" runat="server" />--%>
                                 
                                      </div>
                                    </div>
                                 <div class="row">
                              <div class="col-md-12 fw-light" >
                                  
                                  <video runat="server" width="280" height="300" src='<%# Eval("VideoLink") %>' controls></video>

                                    </div>
                                     </div>
                         <div class="row">
                                   <div class="col-md-12 text-center">
                                   
                                
                                       <asp:Label ID="LabCap" style="font-size:20px;color:#2D033B" runat="server" Text='<%# Eval("Caption") %>'></asp:Label>
                                   
                                    </div>
                              </div>
           <asp:HiddenField ID="HidVidId" value='<%# Eval("VidId") %>' runat="server" ></asp:HiddenField>
                                   
                                       
                                      
                                       
                                  
                         
                                
                             
                            
                              </div>
                              </div>
                           </div>
              <hr />
               
                        </ItemTemplate>

      </asp:DataList>
    </div>
          
             </div>
     
            </div>


   
</section>

</asp:Content>
