<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="DepartmentSetup.aspx.cs" Inherits="HR.UI.DepartmentSetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table style="width:100%;">
    <tr>
        <td style="width: 180px">
            <asp:Label ID="Label1" runat="server" Text="Department Name:" />
        </td>
        <td>
            <asp:TextBox ID="txtDepartmentName" runat="server" />
        </td>
    </tr>

    <tr>
        <td style="width: 180px; height: 32px;">
            Employee Number:</td>
        <td style="height: 32px">
            <asp:TextBox ID="txtEmployeeNumber" runat="server" />
        </td>
    </tr>

    <!-- Hidden ID Field -->
    <tr style="visibility:hidden;">
        <td>
            <asp:Label ID="Label3" runat="server" Text="ID:" />
        </td>
        <td>
            <asp:TextBox ID="txtID" runat="server" />
        </td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Visible="False" />
        </td>
    </tr>

    <tr><td colspan="2">&nbsp;</td></tr>

    <tr>
        <td colspan="2">
            <asp:GridView ID="grdDepartment" runat="server"
    Width="100%"
    AutoGenerateColumns="False"
    AutoPostBack="true"
    CellPadding="4"
    ForeColor="#333333"
    GridLines="None"
    OnRowCommand="grdDepartment_RowCommand"
    OnRowDeleting="grdDepartment_RowDeleting"
    OnSelectedIndexChanged="grdDepartment_SelectedIndexChanged">


                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                <Columns>
                    <asp:TemplateField HeaderText="Department Name">
                        <ItemTemplate>
                            <asp:Label ID="lblDeptName" runat="server" Text='<%# Eval("DepartmentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Employee Number">
                        <ItemTemplate>
                            <asp:Label ID="lblEmpNumber" runat="server" Text='<%# Eval("EmployeeNumber") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ID" Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>

                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </td>
    </tr>

</table>

</asp:Content>
