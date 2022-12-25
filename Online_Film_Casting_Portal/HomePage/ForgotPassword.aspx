<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Online_Film_Casting_Portal.HomePage.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  <div class="container p-5 py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col">
        <div class="card card-registration my-4">
            <h1 class="text-center mx-auto mt-5 mb-5">Reset Password</h1>
            <div class="form-outline mb-4 mx-auto">   
                <asp:Label ID="LabRole"  runat="server" Text="Select Role : "></asp:Label>
                        <asp:DropDownList ID="DDUsers" runat="server" ToolTip="Users">
                         <asp:ListItem>Admin</asp:ListItem>   
                            <asp:ListItem>Actor</asp:ListItem>
                            <asp:ListItem>Director</asp:ListItem>   
                      </asp:DropDownList>
                    </div>
             <div class="form-outline mb-4 w-50 mx-auto">
                  
                    <asp:TextBox ID="TxtEmail" class="form-control form-control-lg" runat="server" AutoPostBack="true" OnTextChanged="TxtEmail_TextChanged"></asp:TextBox>
                   
                  <label class="form-label">Email ID</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvEmail" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtEmail"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RevEmail" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Enter valid Email Id !!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:LinkButton ID="LbSendCode" runat="server" ForeColor="#0000CC" Visible="False" CausesValidation="false" OnClick="LbSendCode_Click">Send Code</asp:LinkButton>
                </div>
               
             <div class="form-outline w-50 mx-auto mb-4">
                        <asp:TextBox ID="txtFPswd" class="form-control form-control-lg" placeholder="Enter otp here" runat="server" AutoPostBack="true" OnTextChanged="txtFPswd_TextChanged"></asp:TextBox>
                      
                        <asp:RequiredFieldValidator ID="RfvFname" runat="server" ControlToValidate="txtFPswd" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LabCodeMsg" runat="server"></asp:Label>
                    </div>
            <div class="form-outline mb-4 mx-auto w-50">                
                    <asp:TextBox ID="TxtPswd" TextMode="Password" ToolTip="- contains at least 8 characters &#013;- contains at least one digit &#013;- contains at least one special character" class="form-control form-control-lg" runat="server" Visible="False"></asp:TextBox>
                  <label class="form-label" >&nbsp;<asp:Label ID="LabNewPswd" runat="server" Text="New Password" Visible="False"></asp:Label>
                    </label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPswd" runat="server" ErrorMessage="Required!!"  ForeColor="Red" ControlToValidate="TxtPswd"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RevNewPswd" runat="server" ControlToValidate="TxtPswd"  ErrorMessage="Please follow password format" ForeColor="Red" ValidationExpression="^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$"></asp:RegularExpressionValidator>
                </div>
                 
                    <div class="form-outline mx-auto w-50">                
                    <asp:TextBox ID="TxtCPswd" TextMode="Password" class="form-control form-control-lg" runat="server" Visible="False"></asp:TextBox>
                  <label class="form-label" >
                        <asp:Label ID="LabNewCPswd" runat="server" Text="Confirm Password" Visible="False"></asp:Label>
                        </label>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvCPswd" runat="server" ErrorMessage="Required!!" ForeColor="Red" ControlToValidate="TxtCPswd"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CompareValidator ID="CvPswd" runat="server" ControlToCompare="TxtPswd" ControlToValidate="TxtCPswd" ErrorMessage="Password mismatch!!!" ForeColor="Red"></asp:CompareValidator>
          </div>
             <div class="mx-auto mb-5 text-danger">
                  <asp:Label ID="LabPswdDes1" runat="server" Text="- contains at least 8 characters" Visible="False"></asp:Label><br />
                  <asp:Label ID="LabPswdDes2" runat="server" Text="- contains at least one digit" Visible="False"></asp:Label><br />
                  <asp:Label ID="LabPswdDes3" runat="server" Text="- contains at least one special character" Visible="False"></asp:Label>
                      <br />
                  <br />
                  <asp:Label ID="LabMsg" runat="server"></asp:Label>
                      </div>
             <div class=" mx-auto mb-5">
                        <asp:Button ID="BtnResetPswd" class="btn btn-success btn-lg" runat="server" Text="Reset Password" OnClick="BtnResetPswd_Click" />
                 <asp:Button ID="BtnCancel" class="btn btn-danger btn-lg" runat="server" Text="Cancel" CausesValidation="false" OnClick="BtnCancel_Click" />
                    </div>
            </div>
          
          
        </div>
      </div>
      </div>
        

    
</asp:Content>
