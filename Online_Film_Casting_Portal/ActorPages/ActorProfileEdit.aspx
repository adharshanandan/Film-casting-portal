<%@ Page Title="" Language="C#" MasterPageFile="~/ActorPages/ActorMaster.Master" AutoEventWireup="true" CodeBehind="ActorProfileEdit.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.ActorProfileEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container mt-5 mb-5 bg-light">
        <div class="row">
            
                    <div>
                        <h1 class="text-center mt-5">Edit Profile</h1>
                    </div>
                    <div class="col-md-6">
                        <div class="p-md-5 text-black">

                       
               
                <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtName"  class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" >Name</label>
                   
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
                    <asp:TextBox ID="TxtDobActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" for="form3Example9">Date of Birth</label>
                   
                </div>

                <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtAddressActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Address</label>
 
                </div>

                   <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtZipActor" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" for="form3Example97">Zip Code</label>
                   
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

                  <div class="col-md-6"> 
                       <div class="p-md-5 text-black">
                     <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtPrevWrks" class="form-control form-control-lg" placeholder="Add description or youtube link etc." runat="server"></asp:TextBox>
                    <label class="form-label" for="form3Example9">Previous Works (if any)</label>
                </div>
                            <div class="form-outline mb-4">
                           <asp:Label ID="LabProPic" class="form-label" runat="server" Text=""></asp:Label>
                                </div>
                           <div class="form-outline mb-4">
                               
                         <asp:FileUpload ID="FuPropicActor" class="form-control form-control-lg" runat="server" ViewStateMode="Enabled" />
                    <label class="form-label" for="form3Example9">Profile Picture </label>
                
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

                           
                           

                </div>
                    </div> 
            </div> 
           <div class="text-center mt-2 mb-5">
<asp:Label ID="LabMsg" runat="server" Text=""></asp:Label>
        </div>

          <div class="row">
                    <div class=" mx-auto mb-5 text-center">
                        <asp:Button ID="BtnUpdate" class="mx-auto btn btn-success btn-lg " runat="server" Text="Update" OnClick="BtnUpdate_Click1"   />

                        <asp:Button ID="BtnCancel" CssClass="mx-auto btn btn-danger btn-lg" runat="server" CausesValidation="false" Text="Cancel" OnClick="BtnCancel_Click1"   />
                      
           
                        
                </div> 
             </div> 
     
        
      
            </div> 
         
  
         

        
           

   
</asp:Content>
