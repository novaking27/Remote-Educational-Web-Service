<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/RemoteEducationalServices.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="RemoteEducationalServicesWebApplication.Pages.Booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td><asp:Label ID="lblWeekBlock" runat="server" Text="Select a Week Block" /></td>
            <td></td>
            <td><asp:DropDownList ID="ddlWeekBlock" runat="server" OnSelectedIndexChanged="ddlWeekBlock_SelectedIndexChanged" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblMonth" runat="server" Text="Month" /></td>
            <td><asp:DropDownList ID="ddlMonth" runat="server" OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged" /></td>
        </tr>
    </table>
    <asp:Button ID="btnBook" runat="server" Text="Book" OnClick="btnBook_Click"/>
</asp:Content>
