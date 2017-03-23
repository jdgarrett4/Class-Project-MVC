<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="Garrett_P3.HomeAdmin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Dylan Garrett's Project 3</h1>
        <p class="lead"></p>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Products by Category Page</h2>
            <p>
               The Products by Category Page lets the user select a category and see the products within the category.
            </p>
            <p>
                <a class="btn btn-default" href="ProductsInCategory.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Single Product Selection</h2>
            <p>
               The Single selection page allows the user to select a product and view the details.
            </p>
            <p>
                <a class="btn btn-default" href="SingleProduct.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Customer by State</h2>
            <p>
              The customer by state page allows the user to select a state and see the customers that live there.
            </p>
            <p>
                <a class="btn btn-default" href="StateAdmin.aspx">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
