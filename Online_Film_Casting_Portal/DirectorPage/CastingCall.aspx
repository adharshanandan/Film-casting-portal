<%@ Page Title="" Language="C#" MasterPageFile="~/DirectorPage/DirectorMaster.Master" AutoEventWireup="true" CodeBehind="CastingCall.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.CastingCall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container w-50 p-2 mx-auto mt-5 mb-5 bg-light">
        <div class="row ">
                    <div>
                        <h1 class="text-center mt-5">Create a Call</h1>
                    </div>
                    
                        <div class="p-md-5 mx-auto  text-black">

                             <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtProCpny"  class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" >Production Company&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                   <asp:RequiredFieldValidator ID="RfvProCpny" runat="server" ControlToValidate="TxtProCpny" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </label>
                   
                &nbsp;</div>

                            <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtMovieName"  class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" >Movie Name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <label class="form-label" >
                    <asp:RequiredFieldValidator ID="RfvMName" runat="server" ControlToValidate="TxtMovieName" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </label>
                   
                </div>

                                <div class="form-outline col-md-6 mb-4">
                        <label class="form-label" >Movie Language</label>
                        <asp:DropDownList ID="DDMLanguage" runat="server"> 
                            <asp:ListItem>Malayalam</asp:ListItem>
                            <asp:ListItem>Tamil</asp:ListItem>
                      </asp:DropDownList>
                    </div>
               
                <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtCharDesc"  class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" >Character Description</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <label class="form-label" >
                    <asp:RequiredFieldValidator ID="RfvCharDesc" runat="server" ControlToValidate="TxtCharDesc" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </label>
                   
                </div>
                         
                               <div class="form-outline mb-4">
                    <asp:TextBox ID="TxtLastDate" TextMode="Date" class="form-control form-control-lg" runat="server"></asp:TextBox>
                    <label class="form-label" >Last Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
&nbsp;<label class="form-label" ><asp:RequiredFieldValidator ID="RfvLDate" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtLastDate"></asp:RequiredFieldValidator>
                                   </label>
                   
                </div>


                <div class="d-md-flex  justify-content-start align-items-center mb-4 py-2">

                  <h6>Gender: </h6>

                  
                      &nbsp;<asp:RadioButtonList ID="RbGender" runat="server" CellPadding="10" RepeatDirection="Horizontal">
                          <asp:ListItem>Male</asp:ListItem>
                          <asp:ListItem>Female</asp:ListItem>
                          <asp:ListItem>Other</asp:ListItem>
                      </asp:RadioButtonList>
                  
                    <asp:RequiredFieldValidator ID="RfvGender"  runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="RbGender"></asp:RequiredFieldValidator>

                </div>

                <div class="row">
                  <div class="col-md-4 mb-4">
                      <label class="form-label" >Country</label>
                      <asp:DropDownList ID="DdCtryDir" runat="server">
                          <asp:ListItem>India</asp:ListItem>
                          
                      </asp:DropDownList>
                  </div>
                  <div class="col-md-4 mb-4">
                      <label class="form-label" >State</label>
                    <asp:DropDownList ID="DdStateDir" runat="server">                     
                          <asp:ListItem>Kerala</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                    <div class="col-md-4 mb-4">
                        <label class="form-label" >District</label>
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
                    <div class="row">
                    
                     <div class="form-outline col-md-4 mb-4">
                        <label class="form-label" >Age from</label>
                        <asp:DropDownList ID="DDAgeFrom" runat="server"> 
                      </asp:DropDownList>
                    </div>
                     <div class="form-outline col-md-4 mb-4">
                        <label class="form-label" >Age to</label>
                        <asp:DropDownList ID="DDAgeTo" runat="server">  
                      </asp:DropDownList>
                    </div>
                    <div class="form-outline col-md-4 mb-4">
                        <label class="form-label" >Total actors needed</label>
                        <asp:DropDownList ID="DDNoOfActors" runat="server">
                      </asp:DropDownList>
                    </div>
                        </div>
                </div>

                            <div class="row">
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <label class="form-label" >Skin tone</label>
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
                        <label class="form-label" >Hair Color</label>
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
                        <label class="form-label" >Eye Color</label>
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

                                    <div class="row">
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <label class="form-label" >Experience</label>
                        <asp:DropDownList ID="DDActExp" runat="server" ToolTip="Select Your Experience">
                 

                          <asp:ListItem>New Face</asp:ListItem>
                            <asp:ListItem>Experienced</asp:ListItem>
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                  <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <label class="form-label" >Body Type</label>
                        <asp:DropDownList ID="DDBodyStruct" runat="server" ToolTip="Select Your Body Type">
                    
                          <asp:ListItem>Fat</asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Lean</asp:ListItem>
                           
                          
                      </asp:DropDownList>
                    </div>
                  </div>
                      <div class="col-md-4 mb-4">
                    <div class="form-outline">
                        <label class="form-label" >Height(in cm) up to</label>
                        <asp:DropDownList ID="DdHeight" runat="server" ToolTip="Select Your Eye Color">
 
                      </asp:DropDownList>
                    </div>
                  </div>
                </div>               
                  </div>
                  
                  

                           <asp:Label ID="LabMsg" runat="server" Text=""></asp:Label>

             <div class="row">
                    <div class=" mx-auto mb-5 text-center">
                        <asp:Button ID="BtnUpload" class="mx-auto btn btn-success btn-lg" runat="server" Text="Upload" OnClick="BtnUpload_Click"   />

                        <asp:Button ID="BtnClr" class="mx-auto btn btn-danger btn-lg" runat="server" CausesValidation="false" Text="Clear" OnClick="BtnClr_Click"  />
                      
           
                        
                </div> 
             </div> 
                           
            </div>
               
          
       
            </div>
</asp:Content>
