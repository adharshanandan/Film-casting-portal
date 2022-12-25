<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="VisitorMessage.aspx.cs" Inherits="Online_Film_Casting_Portal.AdminPage.VisitorMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container p-5 mx-auto mt-5 mb-5 bg-dark">
        <div class="card mb-3">
            <div class="card-body">
                <div class="row ">
            <asp:GridView ID="GvVisMsg" PageSize="6" AllowPaging="True" CssClass="table table-hover" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="CusEmail,CusName,CusId" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
                <Columns>
                    <asp:TemplateField HeaderText="Inquiry Id">
                        <ItemTemplate>
                            <asp:Label ID="LabCusId" runat="server" Text='<%# Eval("CusId") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="LabCusName" runat="server" Text='<%# Eval("CusName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="LabCusEmail" runat="server" Text='<%# Eval("CusEmail") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Message">
                        <ItemTemplate>
                            <asp:Label ID="LabCusMsg" runat="server" Text='<%# Eval("CusMessage") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                            
                    <asp:TemplateField HeaderText="Send Response" ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="BtnSend" CssClass="btn btn-primary" runat="server" Text="Send an email" CausesValidation="false" OnClick="BtnSend_Click" />
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
        <hr />
        <div runat="server" class="container w-50" id="SendMailForm">
            <div class="card">
             <div class="card-body align-content-center">
                 <h3 class="text-center" runat="server" id="Heading" visible="True">Send Email</h3>
                 <asp:Label ID="LabEmailTo" CssClass="mt-3" runat="server" Text="To :"></asp:Label>
                  <div class="row">
            <div class="col-md-12 text-center mx-auto mb-3">
                 <asp:TextBox ID="TxtEmailTo" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:HiddenField ID="HidfldName" runat="server" />
                <asp:HiddenField ID="HidfldId" runat="server" />

                
            </div>
                      </div> 
                 <asp:Label ID="LabMsg" CssClass="mt-3" runat="server" Text="Message :"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RfvMsg" runat="server" ErrorMessage="Required!!" ControlToValidate="TxtMsg" ForeColor="Red"></asp:RequiredFieldValidator>
                 <div class="row">
            <div class="col-md-12 ">
                 <asp:TextBox ID="TxtMsg" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                
            </div>
                     
                      </div> 
                 <div class="text-center mt-3 mx-auto">
                     
                         <asp:Button ID="BtnSendEmail" CssClass="btn btn-primary" runat="server" Text="Send" OnClick="BtnSendEmail_Click"  />
                     <asp:Button ID="BtnCancel" CssClass="btn btn-danger" runat="server" CausesValidation="false" Text="Cancel" OnClick="BtnCancel_Click"  />
                    
                     
                 </div>
                 

        
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
    
</asp:Content>
