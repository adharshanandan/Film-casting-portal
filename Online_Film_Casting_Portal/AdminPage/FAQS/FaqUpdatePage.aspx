<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="FaqUpdatePage.aspx.cs" Inherits="Online_Film_Casting_Portal.AdminPage.FaqUpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container mt-5 bg-dark">
        <div class="row">
            <div class="col-xl-12 mb-4 mt-5 mx-auto">
                <h2 class="text-center mb-5 text-white">Frequently Asked Questions</h2>
                    <div class="form-outline w-50 mx-auto">
                        <asp:TextBox ID="TxtFaqQn" class="form-control form-control-lg " runat="server" TextMode="MultiLine" CausesValidation="True"></asp:TextBox>
                      <label class="form-label text-white" for="form3Example1m">Question&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvQn" runat="server" ControlToValidate="TxtFaqQn" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                        </label>
                    &nbsp;</div>
                 <div class="form-outline w-50 mx-auto">
                        <asp:TextBox ID="TxtFaqAns" class="form-control form-control-lg" runat="server" TextMode="MultiLine" CausesValidation="True"></asp:TextBox>
                      <label class="form-label text-white" for="form3Example1m">Answer&nbsp;&nbsp;&nbsp;&nbsp;
                        </label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <label class="form-label" for="form3Example1m">
                        <asp:RequiredFieldValidator ID="RfvAns" runat="server" ControlToValidate="TxtFaqAns" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                        </label>
                    &nbsp;</div>

                <div class="d-flex justify-content-end pt-3 ">
                    <div class="mx-auto">
                        <asp:Button ID="BtnAddFaq" class="btn btn-success btn-lg" runat="server" Text="Add" OnClick="BtnAddFaq_Click" />
                    
                    
                        <asp:Button ID="BtnClrFaq" class="btn btn-danger btn-lg mx-3" runat="server" CausesValidation="false" Text="Clear" OnClick="BtnClrFaq_Click" />

                    </div>
                    
                    </div>
                
                
                


                

            </div>

        </div>
        <hr class="mb-5 mt-5" />
        <div class="col-xl-12 p-5">
            <h2 class="text-center mb-5 mx-auto text-white">FAQs List</h2>
            <p class="text-center mb-5 mx-auto">
                <asp:Label ID="LabMsg" runat="server"></asp:Label>
            </p>
            <asp:GridView ID="GvFaq" CssClass="mx-auto mb-5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="No." />
                    <asp:BoundField DataField="Question" HeaderText="Question" />
                    <asp:BoundField DataField="Answer" HeaderText="Answer" />
                    <asp:TemplateField HeaderText="Edit" ShowHeader="False">
                        <ItemTemplate>
                            <asp:ImageButton ID="ImgBtnFaqEdit" runat="server" Height="40px" ImageUrl="~/AdminPage/IconImages/Editicon.png" Width="35px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete" ShowHeader="False">
                        <ItemTemplate>
                            <asp:ImageButton ID="ImgBtnFaqDelete" runat="server" Height="40px" ImageUrl="~/AdminPage/IconImages/Deleteicon.png" Width="35px" OnClick="ImgBtnFaqDelete_Click" CausesValidation="False" />
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
    <%--</div>--%>
</asp:Content>
