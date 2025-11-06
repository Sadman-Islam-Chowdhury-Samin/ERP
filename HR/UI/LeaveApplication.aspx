<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs" Inherits="HR.UI.LeaveApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Department Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Leave Duration"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEmployeeName" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDepartmentName" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblLeaveDuration" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Show" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Show" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Show" />
            </td>
        </tr>
    </table>
</asp:Content>
