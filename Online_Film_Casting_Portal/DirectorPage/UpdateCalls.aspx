<%@ Page Title="" Language="C#" MasterPageFile="~/DirectorPage/DirectorMaster.Master" AutoEventWireup="true" CodeBehind="UpdateCalls.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.UpdateCalls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        --bs-card-spacer-y: 1rem;
        --bs-card-spacer-x: 1rem;
        --bs-card-title-spacer-y: 0.5rem;
        --bs-card-border-width: 1px;
        --bs-card-border-color: var(--bs-border-color-translucent);
        --bs-card-border-radius: 0.375rem;
        --bs-card-box-shadow: ;
        --bs-card-inner-border-radius: calc(0.375rem - 1px);
        --bs-card-cap-padding-y: 0.5rem;
        --bs-card-cap-padding-x: 1rem;
        --bs-card-cap-bg: rgba(0, 0, 0, 0.03);
        --bs-card-cap-color: ;
        --bs-card-height: ;
        --bs-card-color: ;
        --bs-card-bg: #fff;
        --bs-card-img-overlay-padding: 1rem;
        --bs-card-group-margin: 0.75rem;
        position: relative;
        display: flex;
        flex-direction: column;
        min-width: 0;
        height: var(--bs-card-height);
        word-wrap: break-word;
        background-color: var(--bs-card-bg);
        background-clip: border-box;
        border-radius: var(--bs-card-border-radius);
        left: 0px;
        top: 0px;
    }
</style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <div class="container  p-2 mx-auto mt-5 mb-5 bg-light">
        <div class="auto-style1">
            <div class="card-body">
                <div class="row ">
            <asp:GridView ID="GvCasting" PageSize="6" AllowPaging="true" CssClass="table table-hover" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="CastId" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" OnRowDataBound="GvCasting_RowDataBound" OnRowCancelingEdit="GvCasting_RowCancelingEdit" OnRowEditing="GvCasting_RowEditing" OnPageIndexChanging="GvCasting_PageIndexChanging" OnRowDeleting="GvCasting_RowDeleting" OnRowUpdating="GvCasting_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Casting Id">
                        <ItemTemplate>
                            <asp:Label ID="LabCastId" runat="server" Text='<%# Eval("CastId") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Production Company">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtProComp" runat="server" Text='<%# Bind("ProductionName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabProComp" runat="server" Text='<%# Bind("ProductionName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Movie Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtMName" runat="server" Text='<%# Bind("MovieName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabMName" runat="server" Text='<%# Bind("MovieName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDGender" runat="server" SelectedValue='<%# Eval("PreGender") %>'>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Other</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabGender" runat="server" Text='<%# Bind("PreGender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Number of Actors">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDNoOfAct" runat="server">
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabNoOfAct" runat="server" Text='<%# Bind("NoOfActors") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Age From">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDAgeFrom" runat="server">
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabAgeFrom" runat="server" Text='<%# Bind("AgeFrom") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Age To">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DdAgeTo" runat="server">
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabAgeTo" runat="server" Text='<%# Bind("AgeTo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Character Description">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtCharDesc" runat="server" Text='<%# Bind("CharacterDiscription") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabCharDesc" runat="server" Text='<%# Bind("CharacterDiscription") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Experience">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDExp" runat="server" SelectedValue='<%# Eval("PreExperience") %>'>
                                <asp:ListItem>New Face</asp:ListItem>
                                <asp:ListItem>Experienced</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabExp" runat="server" Text='<%# Bind("PreExperience") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Language">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDLang" runat="server" SelectedValue='<%# Eval("MovieLanguage") %>'>
                                <asp:ListItem>Malayalam</asp:ListItem>
                                <asp:ListItem>Tamil</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabLang" runat="server" Text='<%# Bind("MovieLanguage") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Posted Date">
                        <ItemTemplate>
                            <asp:Label ID="LabPDate" runat="server" Text='<%# Eval("PostedDate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Date">
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtLDate" runat="server" Text='<%# Bind("LastDate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabLDate" runat="server" Text='<%# Bind("LastDate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit" ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LbUpdate" runat="server" CausesValidation="True" CommandName="Update" ForeColor="Blue" Text="Update"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LbCancel" runat="server" CausesValidation="False" CommandName="Cancel" ForeColor="Red" Text="Cancel"></asp:LinkButton>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="LbEdit" runat="server" CausesValidation="False" CommandName="Edit" ForeColor="Blue" Text="Edit"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LbDelete" runat="server" CausesValidation="False" CommandName="Delete" ForeColor="Red" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
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
      <br />

    


</asp:Content>
