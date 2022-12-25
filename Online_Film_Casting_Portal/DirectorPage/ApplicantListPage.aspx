<%@ Page Title="" Language="C#" MasterPageFile="~/DirectorPage/DirectorMaster.Master" AutoEventWireup="true" CodeBehind="ApplicantListPage.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.ApplicantListPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="container-fluid mb-2 mt-2 bg-light ">
        <div class="row">
            <div class="col-lg-12 mx-auto text-center mt-5">
                <h2 class="text-center mb-5 text-dark mx-auto">Applicants List</h2>
            </div>
             
        </div>
        <div class="row">
            <div class="col-lg-3 mt-3 mb-3">
                <div class="card bg-light">
                    <div class="card  bg-dark">
                    
                    <div class="card-body p-5 text-light  col-md-12"">
                          <div class="col-md-12 mb-5 mt-3" >
                                   <asp:Label ID="Label6" style="font-size:30px;color:white" runat="server" Text="Filters"></asp:Label>
                          <hr />          
                          </div>
                        
                        <div class="row mt-3 mb-3">
                            
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabExp" class="text-white" runat="server" Text="Experience"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList runat="server" ID="DDExp"  AutoPostBack="True" OnSelectedIndexChanged="DDExp_SelectedIndexChanged">
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">All</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">New Face</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Experienced</asp:ListItem>
                                  </asp:DropDownList>
                                
                                    </div>
                                </div>
                            <hr />
                                
                            <div class="row mt-3 mb-3">
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabGender" class="text-white" runat="server" Text="Gender"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList runat="server" ID="DDGender" AutoPostBack="True" OnSelectedIndexChanged="DDGender_SelectedIndexChanged">
                                      <asp:ListItem>All</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Male</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Female</asp:ListItem>
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">Other</asp:ListItem>
                                  </asp:DropDownList>
                                
                                    </div>
                                 </div>
    <hr class="text-white" />
                         <div class="row mt-3 mb-3">
                            
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabAge" class="text-white" runat="server" Text="Age (maximum)"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList ID="DDAge" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDAge_SelectedIndexChanged">
                                      <asp:ListItem>All</asp:ListItem>
                                      
                                      
                                  </asp:DropDownList>
                                
                                    </div>
                                </div>
                            <hr />
                         <div class="row mt-3 mb-3">
                            
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabDist" class="text-white" runat="server" Text="District"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList runat="server" ID="DDDist"  AutoPostBack="True" OnSelectedIndexChanged="DDDist_SelectedIndexChanged">
                                      <asp:ListItem style="margin-left:10px;margin-right:1px">All</asp:ListItem>
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
                            <hr />
                         <div class="row mt-3 mb-3">
                            
                            <div class="col-md-6 ">
                                   <asp:Label ID="LabCastId" class="text-white" runat="server" Text="Casting Id"></asp:Label>
                                
                                    </div>
                             <div class="col-md-6 ">
                                
                                  <asp:DropDownList ID="DDCastId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDCastId_SelectedIndexChanged">
                                  </asp:DropDownList>
                                
                                    </div>
                                </div>
                            <hr />
                        <div class="row mt-5 mb-3">
                            <div class="col-md-6 mx-auto ">

                             </div>
                             <div class="col-md-6 mx-auto text-center">
                         <asp:Button Id="BtnRefresh" CommandName="DirId"  class="btn btn-primary" runat="server" Text="Reset" OnClick="BtnRefresh_Click"    />

                             </div>
                                </div>
                              
                    
                    
                </div>

            </div>
                </div>

            </div>

    <div class="col-xl-9">
           
            <p class="text-center mb-3 mx-auto">
                <asp:Label ID="LabMsg" runat="server"></asp:Label>
            </p>
            <asp:GridView ID="GvAppList" CssClass="mx-auto mb-3 table table-hover" runat="server" AutoGenerateColumns="False" BackColor="#CCFFFF" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ActorEmail" AllowPaging="True" CellSpacing="4" HorizontalAlign="Center" PageSize="6">
                <Columns>
                    <asp:BoundField DataField="ActorName" HeaderText="Actor Name" />
                   
                    <asp:BoundField DataField="ActorEmail" HeaderText="Email" />
                   
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                   
                    <asp:BoundField DataField="ActorGender" HeaderText="Gender" />
                   
                    <asp:TemplateField HeaderText="Photo">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProPicActor") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="ImgProPic" runat="server" Height="185px" ImageUrl='<%# Eval("ProPicActor") %>' Width="188px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ActorState" HeaderText="State" />
                    <asp:BoundField DataField="ActorDist" HeaderText="District" />
                    <asp:BoundField DataField="NeworExperienced" HeaderText="Experience" />
                    <asp:BoundField DataField="ActorPhone" HeaderText="Phone" />
                    <asp:BoundField DataField="AccType" HeaderText="Account Type" />
                    <asp:TemplateField HeaderText="View" ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="BtnView" class="btn btn-primary" runat="server" Text="View Profile" OnClientClick="aspnetForm.target ='_blank';" OnClick="BtnView_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                </Columns>
                <EditRowStyle BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
        </div>

</div>
    </div>
</asp:Content>
