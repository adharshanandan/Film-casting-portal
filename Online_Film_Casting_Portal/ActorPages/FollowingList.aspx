<%@ Page Title="" Language="C#" MasterPageFile="~/ActorPages/ActorMaster.Master" AutoEventWireup="true" CodeBehind="FollowingList.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.FollowingList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class=" container-xxl mt-3 mb-3">


     <div class="col-lg-7 text-center mx-auto">

                <div class="card  bg-dark">
                    
                    <div class="card-body  col-md-12"">
                         <div class="d-flex mt-2 mb-5 mt-5">
                             <asp:TextBox ID="TxtFindDir" class="form-control me-2 mx-auto" placeholder="Find Directors" runat="server"></asp:TextBox>
        
        <button class="btn btn-outline-primary mx-auto text-center" runat="server" id="BtnFindDir" onserverclick="BtnFindDir_ServerClick" type="submit">Search</button>
      </div>
                          <div class="col-md-12 mb-3" >
                                   <asp:Label ID="Label4" style="font-size:30px;color:white" runat="server" Text="Followings"></asp:Label>
                                    </div>
                    <asp:DataList ID="DlFollowings" runat="server"  style="width:100% " DataKeyField="DirId" OnItemDataBound="DlFollowings_ItemDataBound"  > 
                        <ItemTemplate>
                            <div class="w-75 shadow-lg mt-3 mb-3 text-center mx-auto rounded " style="background-color:#FFFAFA">
                          <div class="row align-items-center col-md-12 d-absolute p-3 gx-auto ">
                             

                              <div class="col-md-3 m-0 p-0">
                                  <asp:Image class="rounded-circle" Width="50px" Height="50px" ImageUrl='<%# Eval("ProPicDir")%>' runat="server"></asp:Image>
                                
                                    </div>
                                 
                              <div class="col-md-3 fw-light m-0 p-0" >
                                   <asp:Label ID="LabDirName" style="font-size:20px;color:#2D033B" runat="server" Text='<%# Eval("DirName") %>'></asp:Label>
                                    </div>
                                   <div class="col-md-3 m-0 p-0">
                                   
                                
                                       <asp:Button Id="BtnViewProfile" CommandName="DirId" CommandArgument='<%# Eval("DirEmail") %>'  class="btn btn-primary" runat="server" Text="View Profile" OnClick="BtnViewProfile_Click"   />
                                   
                                    </div>
                              <div class="col-md-3 m-0 p-0  float-right">
                                   
                                 <asp:Button Id="BtnUnFollow" CommandName="DirId" CommandArgument='<%# Eval("DirEmail") %>'  class="btn btn-primary" runat="server" Text="Unfollow" OnClick="BtnUnFollow_Click"   />
                                      
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

</asp:Content>
