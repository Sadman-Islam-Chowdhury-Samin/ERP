<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="DepartmentSetup.aspx.cs" Inherits="HR.UI.DepartmentSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label1" runat="server" Text="Department Name:"></asp:Label>
            </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">&nbsp;</td>
            <td style="width: 344px">
                <asp:Label ID="lblDepartmentName" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">&nbsp;</td>
            <td style="width: 344px">
                <asp:Button ID="Button1" runat="server" Text="Show" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label2" runat="server" Text="Employee Number:"></asp:Label>
            </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtEmployeeNumber" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px; height: 26px"></td>
            <td style="width: 344px; height: 26px">
                <asp:Label ID="lblEmployeeNumber" runat="server"></asp:Label>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 216px">&nbsp;</td>
            <td style="width: 344px">
                <asp:Button ID="Button2" runat="server" Text="Show" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
