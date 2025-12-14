<%--<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="HR.UI.Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;">

        <!-- Employee Name -->
        <tr>
            <td style="width: 186px">
                <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <!-- Attendance Date -->
        <tr>
            <td style="width: 186px">
                <asp:Label ID="Label2" runat="server" Text="Attendance Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAttendanceDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>

        <!-- IsPresent TRUE/FALSE -->
        <tr>
            <td style="width: 186px">
                <asp:Label ID="Label3" runat="server" Text="Present?"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPresent" runat="server">
                    <asp:ListItem Text="-- Select --" Value=""></asp:ListItem>
                    <asp:ListItem Text="Present" Value="true"></asp:ListItem>
                    <asp:ListItem Text="Absent" Value="false"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <!-- Hidden ID -->
        <tr style="visibility:hidden">
            <td>ID</td>
            <td><asp:TextBox ID="txtID" runat="server" /></td>
        </tr>

        <!-- Buttons -->
        <tr>
            <td style="width: 186px">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Visible="False" />
            </td>
            <td></td>
        </tr>

        <!-- Grid View -->
        <tr>
    <td colspan="2">
        <asp:GridView ID="grdAttendance" runat="server"
            AutoGenerateColumns="False"
            OnRowCommand="grdAttendance_RowCommand"
            OnRowDeleting="grdAttendance_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None">

            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

            <Columns>
                <asp:TemplateField HeaderText="Employee Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("EmployeeName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Date">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%# Eval("AttendanceDate","{0:yyyy-MM-dd}") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Present">
                    <ItemTemplate>
                        <asp:Label ID="lblPresent" runat="server" Text='<%# Eval("IsPresent") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField Visible="false">
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

</asp:Content>--%>

<%@ Page Language="C#" MasterPageFile="~/HRSite.Master"
    AutoEventWireup="true" CodeBehind="Attendance.aspx.cs"
    Inherits="HR.UI.Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table style="width:100%;">

    <tr>
        <td style="width:180px">Employee Name</td>
        <td><asp:TextBox ID="txtEmployeeName" runat="server" /></td>
    </tr>

    <tr>
        <td>Attendance Date</td>
        <td><asp:TextBox ID="txtAttendanceDate" runat="server" TextMode="Date" /></td>
    </tr>

    <tr>
        <td>Present?</td>
        <td>
            <asp:DropDownList ID="ddlPresent" runat="server">
                <asp:ListItem Text="Present" Value="true" />
                <asp:ListItem Text="Absent" Value="false" />
            </asp:DropDownList>
        </td>
    </tr>

    <!-- Hidden ID -->
    <tr style="visibility:hidden">
        <td>ID</td>
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
            <asp:GridView ID="grdAttendance" runat="server"
                AutoGenerateColumns="False"
                OnRowCommand="grdAttendance_RowCommand"
                OnRowDeleting="grdAttendance_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">

                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                <Columns>
                    <asp:TemplateField HeaderText="Employee Name">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("EmployeeName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label ID="lblDate" runat="server" Text='<%# Eval("AttendanceDate","{0:yyyy-MM-dd}") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Present">
                        <ItemTemplate>
                            <asp:Label ID="lblPresent" runat="server" Text='<%# Eval("IsPresent") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField Visible="false">
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
