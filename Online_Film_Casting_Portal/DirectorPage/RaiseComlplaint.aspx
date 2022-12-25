<%@ Page Title="" Language="C#" MasterPageFile="~/DirectorPage/DirectorMaster.Master" AutoEventWireup="true" CodeBehind="RaiseComlplaint.aspx.cs" Inherits="Online_Film_Casting_Portal.DirectorPage.RaiseComlplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="container mt-5 mb-5 bg-light">
        <div class="row">
            <div class="col-xl-12 mb-4 mt-5 mx-auto">
                <h2 class="text-center mb-5">Let us know</h2>
                    <div class="form-outline w-50 mx-auto">
                        <asp:TextBox ID="TxtCom" class="form-control form-control-lg " runat="server" TextMode="MultiLine" CausesValidation="True"></asp:TextBox>
                      <label class="form-label" for="form3Example1m">What do you want us to know?&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RfvQn" runat="server" ControlToValidate="TxtCom" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                        </label>
                    &nbsp;</div>
                

                <div class="d-flex justify-content-end pt-3 ">
                    <div class="mx-auto">
                        <asp:Button ID="BtnAddCom" class="btn btn-success btn-lg" runat="server" Text="Add" OnClick="BtnAddCom_Click" />
                    
                    
                        <asp:Button ID="BtnClrFaq" class="btn btn-danger btn-lg mx-3" runat="server" CausesValidation="false" Text="Clear" OnClick="BtnClrFaq_Click"/>

                    </div>
                    
                    </div>
                <div class="d-flex justify-content-end mt-5 pt-3 ">
                    <asp:Label runat="server" ID="LabMsg"></asp:Label>
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
    
</asp:Content>
