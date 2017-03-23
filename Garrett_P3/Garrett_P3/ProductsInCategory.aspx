<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsInCategory.aspx.cs" Inherits="Garrett_P3.ProductsInCategory" Trace="true" Debug="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 style="color: #2011ed">Project 3</h1>
        <p class="lead">Products per Category</p>
    </div>
    <p></p>
    <br />

    <asp:DropDownList ID="ddlCategories" runat="server" OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:GridView ID="gvProducts" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="table table-border table-striped" DataKeyNames="SKU"  Height="64px"  Width="783px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:ImageField DataImageUrlField="ImageProduct" DataImageUrlFormatString="Images_Products/{0}">
                </asp:ImageField>
                <asp:BoundField DataField="SKU" HeaderText="SKU" ReadOnly="True" SortExpression="SKU" />
                <asp:BoundField DataField="Product_Name" HeaderText="Product_Name" SortExpression="Product_Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
            </Columns>
        </asp:GridView>



</asp:Content>
