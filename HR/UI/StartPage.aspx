<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="HR.UI.StartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="lblStartPage" runat="server" Text="Start Page"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGoToEmployeeInfo" runat="server" OnClick="btnGoToEmployeeInfo_Click" Text="Employee Information Page" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGoToCompanySetup" runat="server" OnClick="btnGoToCompanySetup_Click" Text="Company Setup page" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGoToDepartmentSetup" runat="server" OnClick="btnGoToDepartmentSetup_Click" Text="Department Setup Page" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGoToAttendance" runat="server" OnClick="btnGoToAttendance_Click" Text="Attendance Page" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGoToLeaveApplication" runat="server" OnClick="btnGoToLeaveApplication_Click" Text="Leave Application Page" />
            </td>
        </tr>
    </table>
</asp:Content>
