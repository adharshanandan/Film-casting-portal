<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="DirectorDetails.aspx.cs" Inherits="Online_Film_Casting_Portal.AdminPage.UserDatabase.DirectorDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5 bg-dark">
        <div class="row">
    <div class="col-xl-12 p-5">
            <h2 class="text-center mb-5 mx-auto text-white">Directors List</h2>
            <p class="text-center mb-5 mx-auto">
                <asp:Label ID="LabMsg" runat="server"></asp:Label>
            </p>
        <div class="mb-5">
            <asp:GridView ID="GvDirList" CssClass="mx-auto mb-5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="DirId" style="margin-top: 0px">
                <Columns>
                    <asp:BoundField DataField="DirId" HeaderText="Director Id" />
                    <asp:BoundField DataField="DirName" HeaderText="Name" />
                    <asp:BoundField HeaderText="Date of Birth" DataField="DirDob" />
                    <asp:BoundField DataField="DirGender" HeaderText="Gender" />
                    <asp:BoundField HeaderText="Email" DataField="DirEmail" />
                    <asp:BoundField HeaderText="Phone Number" DataField="DirPh" />
                    <asp:BoundField HeaderText="Account Status" DataField="DirAccStatus" />
                    <asp:TemplateField HeaderText="Activate" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LbtnActivate" runat="server" ForeColor="#009933" OnClick="LbtnActivate_Click" >Activate</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Deactivate" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LBtnDeActivate" runat="server" ForeColor="Red"  OnClick="LBtnDeActivate_Click">Deactivate</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                </Columns>
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
        </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
