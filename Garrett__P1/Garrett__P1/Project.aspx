<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="Garrett__P1.Project" Trace="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>Number of Rafters</td>
            <td>
                <asp:TextBox ID="txtNumberOfRafters" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>River Tour</td>
            <td>
                <asp:DropDownList ID="ddlRiverTour" runat="server">
                    <asp:ListItem Value="F">French Broad</asp:ListItem>
                    <asp:ListItem Value="N">Nantahala</asp:ListItem>
                    <asp:ListItem Value="T">Tuck</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Weekday or Weekend</td>
            <td>
                <asp:RadioButtonList ID="rblWeek" runat="server">
                    <asp:ListItem Value="WkD">Weekday</asp:ListItem>
                    <asp:ListItem Value="WkE">Weekend</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Guided</td>
            <td>
                <asp:CheckBox ID="chkGuided" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="butCalculate" runat="server" OnClick="butCalculate_Click" Text="Calculate" />
            </td>
            <td>
                <asp:Button ID="butClear" runat="server" Text="Clear" OnClick="butClear_Click" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <table>
        <tr>
            <td>Total Base Tour Fee</td>
            <td>
                <asp:Label ID="lblTotalBaseFee" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Number of Rafts Needed</td>
            <td>
                <asp:Label ID="lblNumberOfRafts" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Total Guide Fee</td>
            <td>
                <asp:Label ID="lblTotalGuideFee" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
       <tr>
           <td>Total Weekend Surcharge</td>
           <td>
               <asp:Label ID="lblTotalWeekend" runat="server" Text="Label"></asp:Label>
           </td>
       </tr>
        <tr>
            <td>Subtotal</td>
            <td>
                <asp:Label ID="lblSubtotal" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Sales Tax Charge</td>
            <td>
                <asp:Label ID="lblSalesTaxCharge" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Total Charge</td>
            <td>
                <asp:Label ID="lblTotalCharge" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

    </table>


</asp:Content>

