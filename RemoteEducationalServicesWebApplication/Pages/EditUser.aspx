<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/RemoteEducationalServices.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="RemoteEducationalServicesWebApplication.Pages.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Edit User Details</h1>
    <table>
        <tr>
            <td><asp:Label ID="lblFirstName" runat="server" Text="First Name:"/></td>
            <td><asp:TextBox ID="txtFirstName" placeholder="First Name Here" runat="server"/></td>
            

        </tr>
         <tr >
            <td><asp:Label ID="lblLastName" runat="server" Text="Last Name:"/></td>
            <td><asp:TextBox ID="txtLastName" placeholder="Last Name Here" runat="server"/></td>
           
        </tr>
         <tr>
            <td><asp:Label ID="lblEmail" runat="server" Text="Email:"/></td>
            <td><asp:TextBox ID="txtEmail" placeholder="Email Address Here" runat="server"/></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDob" runat="server" Text="Date Of Birth:"/></td>
            <td><asp:TextBox ID="txtDob" placeholder="Date of Birth Here" runat="server"/></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:"/></td>
            <td><asp:TextBox ID="txtPhoneNumber" placeholder="Phone Number Here" runat="server"/></td>
            <td></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblStreetName" runat="server" Text="Street Name:"/></td>
            <td><asp:TextBox ID="txtStreetName" placeholder="Street Name Here" runat="server"/></td>
             <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblHouseNumber" runat="server" Text="House Number:"/></td>
            <td><asp:TextBox ID="txtHouseNumber" placeholder="House Number Here" runat="server"/></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblUnitNumber" runat="server" Text="Unit Number:"/></td>
            <td><asp:TextBox ID="txtUnitNumber" placeholder="Unit Number Here" runat="server"/></td>
            <td></td>
        </tr>
          <tr>
            <td><asp:Label ID="lblSuburb" runat="server" Text="Suburb:"/></td>
            <td><asp:TextBox ID="txtSuburb" placeholder="Suburb Here" runat="server"/></td>
              <td></td>
        </tr>
          <tr>
            <td><asp:Label ID="lblPostCode" runat="server" Text="PostCode:"/></td>
            <td><asp:TextBox ID="txtPostCode" placeholder="PostCode Here" runat="server"/></td>
              <td></td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td><asp:Label ID="lblUserName" runat="server" Text="Username:"/></td>
            <td><asp:TextBox ID="txtUserName" placeholder="Username Here" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPassword" runat="server" Text="Password:"/></td>
            <td><asp:TextBox ID="txtPassword" placeholder="Password Here" TextMode="Password" runat="server"/></td>
           
        </tr>
        <tr>
            <td><asp:Button ID="btnEdit" runat="server" Text="Update" OnClick="btnEdit_Click" /></td>
        </tr>

    </table>

</asp:Content>
