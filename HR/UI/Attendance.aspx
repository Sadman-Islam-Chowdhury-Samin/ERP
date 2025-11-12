<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="HR.UI.Attendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 186px">
                <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px; width: 186px">
                <asp:Label ID="Label3" runat="server" Text="Day 1"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:TextBox ID="txtDay1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 186px">
                <asp:Label ID="Label4" runat="server" Text="ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 186px">
                <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grdAttendance" runat="server" Width="100%">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
