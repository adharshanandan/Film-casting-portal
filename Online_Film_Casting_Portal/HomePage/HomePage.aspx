<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainMaster.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Online_Film_Casting_Portal.HomePage.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 484px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--IMAGE CAROUSEL--%>
<div class="bg-dark">
 <div id="carouselExampleInterval" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active col-12" data-bs-interval="3000">
      <img src="Wallpaper%20carousel/image1.jpg" class="d-block w-75 h-50 img mx-auto" alt="...">
    </div>
    <div class="carousel-item col-12" data-bs-interval="3000">
      <img src="Wallpaper%20carousel/image2.jpg" class="d-block w-75 h-50 img mx-auto" alt="...">
    </div>
   
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
    </div>

    <%--QUOTE AND ABOUT US--%>
 <div class="bg-light">
    <div class="container-fluid">
            <div class="row">
                <div class="col-md-6 pt-5" >
                    <h3 class="text-center text-black pt-5 mt-5"><i>“Acting is behaving truthfully under imaginary circumstances.”</i></h3>
                </div>

                <div class="col-md-6 p-5" style="background-color:#F1EEF6">
                    <h2 class="text-center text-black pt-3">About Us</h2>
                    <div class="pt-4 text-lg-left" style="font-size:20px">
                    <p >Cast Talents is the online film casting portal in India. Founded in 2022,
                        The popularity of the portal is evident from the fact that it has crossed the thousands of the artists
                        landmark and has exciting opportunity for film seekers from famous directors on the site.</p>

                    <p>Cast Talents works closely to bridge the gap between talent & opportunities.
                        It brings Artists and top Directors under one roof. Our mission is to replace the conventional
                        process of casting with this web based application and we are always here to help you.
                      </p>
                        </div>

                </div>
             
            </div>
            </div>
        </div>


  
 

  <section class="d-flex justify-content-center justify-content-lg-between p-4 border-bottom" style="background-color:#F2F2F2">

    <div class="me-5 d-none d-lg-block mx-auto ">
      <span>Get connected with us on social networks:</span>
    </div>

    <div class="mx-auto">
     <a href="#" class="me-4 link-secondary">
        <i class="fab fa-facebook-f"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-twitter"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-google"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-instagram"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-linkedin"></i>
      </a>
      <a href="#" class="me-4 link-secondary">
        <i class="fab fa-github"></i>
      </a>
 
    </div>
  
  </section>


 
</asp:Content>
