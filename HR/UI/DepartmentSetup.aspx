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
            <td style="width: 216px">
                <asp:Label ID="Label2" runat="server" Text="Employee Number:"></asp:Label>
            </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtEmployeeNumber" runat="server" OnTextChanged="txtEmployeeNumber_TextChanged"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label3" runat="server" Text="ID:"></asp:Label>
            </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                &nbsp;</td>
            <td style="width: 344px">
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px" colspan="3">
                <asp:GridView ID="grdDepartment" runat="server" Width="100%">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">&nbsp;</td>
            <td style="width: 344px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
