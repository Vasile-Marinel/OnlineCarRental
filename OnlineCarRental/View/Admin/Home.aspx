<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineCarRental.View.Admin.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container mt-5 ml-5">
        <div class="row-accordion">

            <div class="jumbotron bg-warning">
                <div class="container">
                    <h1 class="display-4">Car Rental Management System Admin Panel</h1>
                    <p class="lead">The Admin Can Manage Cars, Customers, Rentals and Returns</p>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/honda.png" alt="" width="300"></div><div><h6 class="text-danger">Honda Fit Specs 2019</h6></div></div>
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/Mercedes-Benz-GLB.png" alt="" width="200"></div><div><h6 class="text-danger">Mercedes Benz GLB 2019</h6></div></div>
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/audi-a6-2018.png" alt="" width="300"></div><div><h6 class="text-danger">Audi A6 2018</h6></div></div>
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/Tesla.jpeg" alt="" width="300"></div><div><h6 class="text-danger">Tesla Model S 2020</h6></div></div>
        </div>
        <div class="row">
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/bmw-7-series-2019.jpeg" alt="" width="300"></div><div><h6 class="text-danger">BMW 7 Series 2019</h6></div></div>
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/hyundai-tucson-pure-white-2021.jpg" alt="" width="300"></div><div><h6 class="text-danger">Hyundai Tucson 2021</h6></div></div>
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/renault-symbol-2019.jpeg" alt="" width="300"></div><div><h6 class="text-danger">Renault Symbol 2019</h6></div></div>
            <div class="col-lg-3 col-md-6"><div><img src="../../Assets/Img/nissan-xtrail-2022.jpeg" alt="" width="300"></div><div><h6 class="text-danger">Nissan X-Trial 2022</h6></div></div>
        </div>
    </div>
</asp:Content>
