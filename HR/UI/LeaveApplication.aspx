<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs" Inherits="HR.UI.LeaveApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 168px; height: 29px">
                <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
            </td>
            <td style="height: 29px">
                <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
            </td>
            <td style="height: 29px">
            </td>
        </tr>
        <tr>
            <td style="width: 168px">
                <asp:Label ID="Label3" runat="server" Text="Leave Duration"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLeaveDuration" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 168px">
                <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 168px">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grdLeave" runat="server" Width="100%">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
