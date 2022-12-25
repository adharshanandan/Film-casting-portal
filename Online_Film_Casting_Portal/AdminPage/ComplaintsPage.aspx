<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ComplaintsPage.aspx.cs" Inherits="Online_Film_Casting_Portal.AdminPage.ComplaintsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5 bg-dark">
        <div class="row">
    <div class="col-xl-12 p-3">
            <h2 class="text-center mb-5 mx-auto text-white">Actors Complaints</h2>
            <p class="text-center mb-5 mx-auto">
                <asp:Label ID="LabMsg" runat="server"></asp:Label>
            </p>
            <asp:GridView ID="GvActorCom" CssClass="mx-auto mb-5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ComId">
                <Columns>
                    <asp:BoundField DataField="ComId" HeaderText="No." />
                    <asp:BoundField DataField="UserId" HeaderText="Actor Id" />
                    <asp:BoundField DataField="Username" HeaderText="Actor Name" />
                   
                    <asp:BoundField DataField="Complaints" HeaderText="Complaints" />
                   
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
    <div class="container mt-3 bg-dark">
        <div class="row">

            <div class="col-xl-12 p-3">
            <h2 class="text-center mb-5 mx-auto text-white">Directors Complaints</h2>
            <p class="text-center mb-5 mx-auto">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
            <asp:GridView ID="GvDirCom" CssClass="mx-auto mb-5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ComId">
                <Columns>
                    <asp:BoundField DataField="ComId" HeaderText="No." />
                    <asp:BoundField DataField="UserId" HeaderText="Director Id" />
                    <asp:BoundField DataField="Username" HeaderText="Director Name" />
                   
                    <asp:BoundField DataField="Complaints" HeaderText="Complaints" />
                   
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
</asp:Content>
