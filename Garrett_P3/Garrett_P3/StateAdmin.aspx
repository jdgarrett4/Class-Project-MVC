<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StateAdmin.aspx.cs" Inherits="Garrett_P3.StateAdmin" Debug="true" Trace="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 style="color: #2011ed">Project 3</h1>
        <p class="lead">Customers by State</p>
    </div>
    <p></p>
    <br />
    <br />
    <asp:DropDownList ID="ddlStates" runat="server" OnSelectedIndexChanged="ddlStates_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <br />
    <asp:DataList ID="dataListStates" runat="server" CssClass="table table-bordered table-striped">
        <ItemTemplate>
                <asp:Label ID="lblFirstName" runat="server" Font-Bold="False" Text='<%# Eval("FirstName") %>'></asp:Label>
                &nbsp;<asp:Label ID="lblLastName" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
            &nbsp;<asp:Label ID="lblEmail" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
            &nbsp;<asp:Label ID="lblAdress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
            &nbsp;<asp:Label ID="lblCity" runat="server" Text='<%# Eval("City") %>'></asp:Label>
            &nbsp;<asp:Label ID="lblState" runat="server" Text='<%# Eval("State") %>'></asp:Label>
            &nbsp;<asp:Label ID="lblZipCode" runat="server" Text='<%# Eval("ZipCode") %>'></asp:Label>
            &nbsp;<asp:Label ID="lblPhoneNumber" runat="server" Text='<%# Eval("PhoneNumber") %>'></asp:Label>
            </ItemTemplate>

    </asp:DataList>
</asp:Content>
