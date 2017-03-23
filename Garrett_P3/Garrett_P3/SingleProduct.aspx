<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingleProduct.aspx.cs" Inherits="Garrett_P3.SingleProduct" Trace="true" Debug="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 style="color: #2011ed">Project 3</h1>
        <p class="lead">Single Product Selection</p>
    </div>
    <p></p>
    <br />
    <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <br />
    <asp:DetailsView ID="dvProducts" runat="server" Height="50px" Width="125px" CssClass="table table-bordered table-striped" AutoGenerateRows="False">
        <Fields>
            <asp:ImageField DataImageUrlField="ImageProduct" DataImageUrlFormatString="Images_Products/{0}">
            </asp:ImageField>
            <asp:BoundField DataField="SKU" HeaderText="SKU" ReadOnly="True" SortExpression="SKU" />
            <asp:BoundField DataField="Product_Name" HeaderText="Product_Name" SortExpression="Product_Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" DataFormatString="{0:C}" />
        </Fields>
    </asp:DetailsView>

</asp:Content>
