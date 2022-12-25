<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="FaqDisplay.aspx.cs" Inherits="Online_Film_Casting_Portal.HomePage.FaqDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3 mb-5 w-100">
    <div class="col-lg-12">

                <div class="card  bg-white">
                    
                    <div class="card-body  col-md-12">
                         <div class="text-center mt-3" >
                                   <asp:Label ID="LabTitle" style="font-size:30px;color:black" runat="server" Text="Frequently Asked Questions"></asp:Label>
                                    </div>
                         <div class="d-flex mt-2 mb-5 mt-5 text-center mx-auto col-md-4">
                             <asp:TextBox ID="TxtFindQn" class="form-control me-2" placeholder="Find question" runat="server"></asp:TextBox>
        
        <button class="btn btn-outline-primary" runat="server" id="BtnFindQns" onserverclick="BtnFindQns_ServerClick"  type="submit">Search</button>
      </div>
                         
                    <asp:DataList ID="DlFaqs" runat="server" style="width:100% " DataKeyField="QnId" > 
                        <ItemTemplate>
                            

                            <div class="accordion" id="accordion">
  <div class="accordion-item ">
    <h2 class="accordion-header" id="headingOne">
      <button class="accordion-button" type="button"  data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
         <asp:Label ID="LabQns" style="font-size:20px;color:#2D033B" runat="server" Text='<%# Eval("Question") %>'></asp:Label>
      </button>
    </h2>
    <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
      <div class="accordion-body">
       <asp:Label ID="LabAns" style="font-size:20px;color:#2D033B" runat="server" Text='<%# Eval("Answer") %>'></asp:Label>
      </div>
    </div>
  </div>
  
  
</div>

<hr />
                          
                        </ItemTemplate>
                        

                    </asp:DataList>
                    
                </div>

            </div>

        </div>
        </div>

</asp:Content>
