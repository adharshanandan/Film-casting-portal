<%@ Page Title="" Language="C#" MasterPageFile="~/ActorPages/ActorMaster.Master" AutoEventWireup="true" CodeBehind="GetPremium.aspx.cs" Inherits="Online_Film_Casting_Portal.ActorPages.GetPremium" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <section style="background-color: #eee;">
  <div class="container py-5">
    <div class="row d-flex justify-content-center">
      <div class="col-md-12 col-lg-10 col-xl-8">
        <div class="card">
          <div class="card-body p-md-5">
            <div>
              <h4>Upgrade your plan</h4>
              <p class="text-muted pb-2">
                Please make the payment to start enjoying all the features of our premium
                plan as soon as possible
              </p>
            </div>

            <div class="px-3 py-4 col-md-12">
              <div class="row">
                  <div class="col-md-12">
                     

                            
                 
<%--  -----------------------------------------%>


                       <div class="container">
  
  
  <div class="row">
    
      <div class="col-md-6 col-lg-6">
        <div class="card">
        <div class="card-body rounded" style="background-image:url(PamentPageBg/1155219.jpg);background-size:cover">
            
            <asp:RadioButton ID="RbMonth" AutoPostBack="true" Text="300" GroupName="plan" runat="server" OnCheckedChanged="RbMonth_CheckedChanged" />  
          
            <div>
                <asp:Label runat="server" class="text-light fs-4" Text="Monthly Plan"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" class="text-light fs-2" Text="300/- Only"></asp:Label>
            </div>
           

        
        </div>
    </div>
       
        
      </div>

      <div class="col-md-6 col-lg-6">
        <div class="card">
        <div class="card-body rounded" style="background-image:url(PamentPageBg/1155219.jpg);background-size:cover">
            
               
        <asp:RadioButton ID="RbAnnual" AutoPostBack="true" GroupName="plan" Text="3300" runat="server" OnCheckedChanged="RbAnnual_CheckedChanged" />  
            <div>
                <asp:Label runat="server" class="text-light fs-4" Text="Annual Plan"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" class="text-light fs-2" Text="3300/- Only"></asp:Label>
            </div>
           

        
        </div>
    </div>
       
        
      </div>
     
      
  </div>
  
</div>







                          </div>

             
                  


              </div>
            </div>

            <h4 class="mt-5">Payment details</h4>
              <div class="form-outline mt-4">
                  <asp:TextBox runat="server" ReadOnly="true" class="form-control form-control-lg w-25" ID="TxtAmt"></asp:TextBox>
              
              <label class="form-label" for="formControlLg">Amount</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:RequiredFieldValidator ID="RfvAmt" runat="server" ControlToValidate="TxtAmt" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="form-outline mt-4">
              <asp:TextBox runat="server" class="form-control form-control-lg" ID="TxtAccHolder"></asp:TextBox>
              <label class="form-label" for="formControlLg">Account Holder's Name</label>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RfvAccHName" runat="server" ControlToValidate="TxtAccHolder" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            
              <div class="row mt-3 mb-3">
                  <div class="col-md-6">
                         <div class="form-outline">
                             <label class="form-label" for="formControlLg">Bank Name</label>
                             <asp:DropDownList runat="server" ID="DDBName">
                                 <asp:ListItem>SBI</asp:ListItem>
                             </asp:DropDownList>
              
            </div>
                  </div>
                  <div class="col-md-6">
                         <div class="form-outline">
                             <label class="form-label" for="formControlLg">Branch</label>
                             <asp:DropDownList runat="server" ID="DDBranch">
                                 <asp:ListItem>Punnayurkulam</asp:ListItem>
                                 <asp:ListItem>Kunnamkulam</asp:ListItem>
                             </asp:DropDownList>
              
            </div>
                  </div>

              </div>
              
              <div class="form-outline mb-3">
              <asp:TextBox runat="server" class="form-control form-control-lg" ID="TxtIfsc"></asp:TextBox>
              <label class="form-label" for="formControlLg">IFSC Code&nbsp;&nbsp;&nbsp;
                  <asp:RequiredFieldValidator ID="RfvIfsc" runat="server" ControlToValidate="TxtIfsc" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp; </label>
            &nbsp;</div>
              <div class="form-outline mb-3">
              <asp:TextBox runat="server" class="form-control form-control-lg" ID="TxtAccNo"></asp:TextBox>
              <label class="form-label" for="formControlLg">Account Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:RequiredFieldValidator ID="RfvAccNo" runat="server" ControlToValidate="TxtAccNo" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                  </label>
            &nbsp;</div>
               <div class="form-outline mb-5">
              <asp:TextBox runat="server" placeholder="Enter OTP here" AutoPostBack="true" class="form-control form-control-lg w-25" ID="TxtOtp" OnTextChanged="TxtOtp_TextChanged"></asp:TextBox>
                   <asp:LinkButton ID="LbResend" CausesValidation="false" OnClick="LbResend_Click" runat="server" ForeColor="Blue">Send OTP</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <label class="form-label" for="formControlLg">
                  <asp:RequiredFieldValidator ID="RfvOtp" runat="server" ControlToValidate="TxtOtp" ErrorMessage="Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                  </label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LabMsg" runat="server" Text=""></asp:Label>
            &nbsp;</div>
            <div class="mt-3 mx-auto text-center">
               
                <asp:Button runat="server" class="btn btn-primary btn-block btn-lg" Text="Pay now" ID="BtnPay" OnClick="BtnPay_Click" />
                <asp:Button runat="server" CausesValidation="false" class="btn btn-secondary btn-block btn-lg" Text="Back" ID="BtnBack" OnClick="BtnBack_Click" />
              
          
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
</asp:Content>
