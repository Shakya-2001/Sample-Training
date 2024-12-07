<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="myApp3.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="w-50">
    <tr>
        <td style="width: 164px">User Name</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 164px">Password</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 164px">&nbsp;</td>
        <td>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember Password" />
        </td>
    </tr>
    <tr>
        <td style="width: 164px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </td>
    </tr>
    <tr>
        <td style="width: 164px">&nbsp;</td>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server">New user? Register here.</asp:HyperLink>
        </td>
    </tr>
</table>
</asp:Content>
