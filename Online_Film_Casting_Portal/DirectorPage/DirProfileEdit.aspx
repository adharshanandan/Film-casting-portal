<%@ Page Title="" Language="C#" MasterPageFile="~/DirectorPage/DirectorMaster.Master" AutoEventWireup="true" CodeBehind="DirProfileEdit.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.DirProfileEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container w-50 p-2 mx-auto mt-5 mb-5 bg-light">
        <div class="row ">
                    <div>
                        <h1 class="text-center mt-5">Edit Profile</h1>
                    </div>
                    
                        <div class="p-md-5 mx-auto  text-black">

                       
               
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
                  <div class="col-md-3 mb-4">
                      <asp:DropDownList ID="DdCtryDir" runat="server">
                          <asp:ListItem>India</asp:ListItem>
                          
                      </asp:DropDownList>
                  </div>
                  <div class="col-md-3 mb-4">
                    <asp:DropDownList ID="DdStateDir" runat="server">                     
                          <asp:ListItem>Kerala</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                    <div class="col-md-3 mb-4">
                    <asp:DropDownList ID="DdDistDir" runat="server">                     
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
                     <div class="form-outline col-md-3 mb-4">
                        
                        <asp:DropDownList ID="DDFilmInd" runat="server" ToolTip="Select Film Industry">
                 

                          <asp:ListItem>Malayalam</asp:ListItem>
                            <asp:ListItem>Tamil</asp:ListItem>
                          
                      </asp:DropDownList>
                    </div>
                </div>
                

                <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtDobDir" class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label">Date of Birth</label>
                   
                </div>

                <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtAddressDir" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" >Address</label>
 
                </div>
                            <div class="form-outline mb-4">
                  
                    <asp:TextBox ID="TxtMemId" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label" >Membership Id</label>
 
                </div>

                

                    <div class="form-outline mb-4">                
                    <asp:TextBox ID="TxtPhDir" class="form-control form-control-lg" runat="server"></asp:TextBox>
                  <label class="form-label">Phone Number</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPh" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtPhDir"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RevPh" runat="server" ControlToValidate="TxtPhDir" ErrorMessage="Only 10 digits are allowed!!" ForeColor="Red" ValidationExpression="^[0-9]{10}$"></asp:RegularExpressionValidator>
                </div>



                            <asp:Label ID="LabProPic" class="form-label" runat="server" Text=""></asp:Label>
                  
                           <div class="form-outline mb-4">
                               
                         <asp:FileUpload ID="FuPropicDir" class="form-control form-control-lg" runat="server" ViewStateMode="Enabled" />
                    <label class="form-label" >Profile Picture </label>
                
                </div>
                           
                   
                  </div>
                  
                  

                           <asp:Label ID="LabMsg" runat="server" Text=""></asp:Label>

             <div class="row">
                    <div class=" mx-auto mb-5 text-center">
                        <asp:Button ID="BtnUpdate" class="mx-auto btn btn-success btn-lg" runat="server" Text="Update" OnClick="BtnUpdate_Click"  />

                        <asp:Button ID="BtnCancel" class="mx-auto btn btn-danger btn-lg" runat="server" CausesValidation="false" Text="Cancel" OnClick="BtnCancel_Click"  />
                      
           
                        
                </div> 
             </div> 
                           
            </div>
               
          
       
            </div>
     
</asp:Content>
