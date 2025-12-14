<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master"
    AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs"
    Inherits="HR.UI.LeaveApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table style="width:100%;">

    <tr>
        <td style="width:160px">Employee Name:</td>
        <td><asp:TextBox ID="txtEmployeeName" runat="server" /></td>
    </tr>

    <tr>
        <td>Leave Duration:</td>
        <td><asp:TextBox ID="txtLeaveDuration" runat="server" /></td>
    </tr>

    <!-- Hidden ID -->
    <tr style="visibility:hidden;">
        <td>ID:</td>
        <td><asp:TextBox ID="txtID" runat="server" /></td>
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

    <tr>
        <td colspan="2">
            <asp:GridView ID="grdLeave" runat="server" Width="100%"
                AutoGenerateColumns="False"
                OnRowCommand="grdLeave_RowCommand" OnRowDeleting="grdLeave_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None">

                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                <Columns>
                    <asp:TemplateField HeaderText="Employee Name">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("EmployeeName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Leave Duration">
                        <ItemTemplate>
                            <asp:Label ID="lblDuration" runat="server" Text='<%# Eval("LeaveDuration") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
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
