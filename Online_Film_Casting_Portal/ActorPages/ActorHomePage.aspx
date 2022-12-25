<%@ Page Title="" Language="C#" MasterPageFile="~/ActorPages/ActorMaster.master" AutoEventWireup="true" CodeBehind="ActorHomePage.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.ActorHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label runat="server" ID="LabMsg"></asp:Label>
    <div class="container-fluid mb-2 mt-2">
        <div class="row">
            <div class="col-lg-3 ">
                <div class="card bg-light">
                    <div class="card  bg-light">
                    
                    <div class="card-body p-5  col-md-12" >
                          <div class="col-md-12 mb-5" >
                                   <asp:Label ID="Label6" style="font-size:30px;color:black" runat="server" Text="Filters"></asp:Label>
                          <hr />          
                          </div>
                        
                        <div class="row mt-3 mb-3">
                            
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabExpFilter" class="text-black" runat="server" Text="Experience"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList runat="server" ID="DDExp" OnSelectedIndexChanged="DDExp_SelectedIndexChanged" AutoPostBack="True">
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">All</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">New Face</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Experienced</asp:ListItem>
                                  </asp:DropDownList>
                                
                                    </div>
                                </div>
                            <hr />
                                
                            <div class="row mt-3 mb-3">
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabFIndFilter" class="text-black" runat="server" Text="Film Industry"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList runat="server" ID="DDIndustry" OnSelectedIndexChanged="DDIndustry_SelectedIndexChanged" AutoPostBack="True">
                                      <asp:ListItem>All</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Malayalam</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Tamil</asp:ListItem>
                                  </asp:DropDownList>
                                
                                    </div>
                                 </div>
    <hr />
                         <div class="row mt-3 mb-3">
                            
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabAgeFilter" class="text-black" runat="server" Text="Age"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList ID="DDAge" runat="server" OnSelectedIndexChanged="DDAge_SelectedIndexChanged" AutoPostBack="True">
                                      <asp:ListItem>All</asp:ListItem>
                                      
                                      
                                  </asp:DropDownList>
                                
                                    </div>
                                </div>
                            <hr />
                        <div class="row mt-5 mb-3">
                            <div class="col-md-6 mx-auto ">

                             </div>
                             <div class="col-md-6 mx-auto text-center">
                         <asp:Button Id="BtnRefresh" CommandName="DirId"  class="btn btn-primary" runat="server" Text="Reset" OnClick="BtnRefresh_Click"   />

                             </div>
                                </div>
                              
                    
                    
                </div>

            </div>
                </div>

            </div>
            <div class="col-lg-6">
                <div class="card" style="background-color:#FFFAFA">
                    
                   <div class=" card-body shadow-lg rounded  justify-content-center">

                       <asp:Label style="font-size:25px;color:white" CssClass="bg-dark" ID="LabCount" runat="server" Text=""></asp:Label>
                       <hr />
                        
                    <asp:DataList ID="DlCalls" runat="server" style="width:100%" > 
                        <ItemTemplate>
                            <div class="shadow-lg mt-5 mb-5" style="background-color:#ECF0F1">
                            <hr />
                             <div class="col-md-12 fw-light mx-auto text-center">
                                 <b>
                                <a style="text-decoration:none" href="CastingCallDetails.aspx?id=<%# Eval("CastId") %>">
                                    <asp:Label ID="Label1" style="font-size:35px;color:#2D033B" runat="server" Text='<%# "Casting Call for a "+ Eval("MovieLanguage")+" Movie" %>'></asp:Label>
                                </b>   
                                    </div>
                            <hr />
                                 <div class="text-center fst-italic"  style="font-size:25px;color:black">
                                    <asp:Label ID="Label2"  runat="server" Text='<%# "We are looking for " + Eval("PreExperience")+" "+Eval("PreGender")+" Actor/Actors. " %>'></asp:Label>
                                   
                                    </div>
                               
                                    <div class="text-center p-2">
                                
                                <asp:Image ID="Image1" Width="130px" Height="130px" ImageUrl='<%# Eval("FilmIcon")%>' runat="server" />
                                   
                            
                               
                                <div style="font-size:20px;color:black">
                                    <asp:Label ID="LabMName" runat="server" Text='<%# "Movie Name : "+  Eval("MovieName") %>'></asp:Label>
                                <br />
                                    <asp:Label ID="LabPName" runat="server" Text='<%# "Production Company : " +Eval("ProductionName") %>'></asp:Label>
                                    </div>
                                </div>
                                      
                                
                                <div>
                                    <div class="p-3 fw-ligh" style="font-size:18px;color:black;">
                                    
                                <asp:Label ID="LabCharDesc" runat="server" Text='<%# "Character Description : "+Eval("CharacterDiscription") %>'></asp:Label>
                                            
                                    </div>
                                    </div>
                                <br />
                                <div class="text-center">
                                <a href="CastingCallDetails.aspx?id=<%# Eval("CastId") %>" class="btn btn-primary">View Details</a>
                                    </div>
                                <hr />
                                <div class="row">
                                    <div class="col-lg-6 text-muted mx-auto">
                                 <asp:Label ID="LabPostedDate" CssClass="m-2" runat="server" Text='<%# "Posted on : "+Eval("PostedDate") %>'></asp:Label>
                                        </div>
                                    <div class="col-lg-6 text-muted text-end ">
                                 <asp:Label ID="Label3" runat="server" CssClass="m-2" Text='<%# "Last Date : "+Eval("LastDate") %>'></asp:Label>
                                        </div>
                                    </div>

                          
                            <hr />
                                </div>
                        </ItemTemplate>
                        

                    </asp:DataList>
                            </div>
                          </div>
                        
                

            </div>
            <div class="col-lg-3">

                <div class="card  bg-dark">
                    
                    <div class="card-body  col-md-12"">
                         <div class="d-flex mt-2 mb-5">
                             <asp:TextBox ID="TxtFindDir" class="form-control me-2" placeholder="Find Directors" runat="server"></asp:TextBox>
        
        <button class="btn btn-outline-primary" runat="server" id="BtnFindDir" onserverclick="BtnFindDir_ServerClick" type="submit">Search</button>
      </div>
                          <div class="col-md-12 mb-3" >
                                   <asp:Label ID="Label4" style="font-size:30px;color:white" runat="server" Text="Directors"></asp:Label>
                                    </div>
                    <asp:DataList ID="DlDirDetails" runat="server" style="width:100% " DataKeyField="DirId" OnItemCommand="DlDirDetails_ItemCommand"> 
                        <ItemTemplate>
                            <div class="shadow-lg mt-3 mb-3 rounded " style="background-color:#FFFAFA">
                          <div class="row p-3 d-absolute align-items-center gx-auto g-3">
                             

                              <div class="col-md-4 p-3 m-0">
                                  <asp:Image class="rounded-circle" Width="50px" Height="50px" ImageUrl='<%# Eval("ProPicDir")%>' runat="server"></asp:Image>
                                
                                    </div>
                                 
                              <div class="col-md-4 fw-light p-0 m-0" >
                                   <asp:Label ID="LabDirName" style="font-size:20px;color:#2D033B" runat="server" Text='<%# Eval("DirName") %>'></asp:Label>
                                    </div>
                                   <div class="col-md-4 p-3 m-0 float-end">
                                   
                                
                                       <asp:Button Id="BtnFollow" CommandName="DirId"  class="btn btn-primary" runat="server" Text="Follow"   />
                                   
                                    </div>
                          </div>
                                <asp:HiddenField ID="HidId" value='<%# Eval("DirId") %>' runat="server" ></asp:HiddenField>
                             
                            
                              
                              </div>
                          
                        </ItemTemplate>
                        

                    </asp:DataList>
                    
                </div>

            </div>

        </div>
    </div>
    </div>
</asp:Content>
