<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="HR.UI.Attendance" %>

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

        <!-- Buttons -->
        <tr>
            <td style="width: 186px">
                <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td>
            <td></td>
        </tr>

        <!-- Grid View -->
        <tr>
            <td colspan="2">
                <asp:GridView ID="grdAttendance" runat="server" Width="100%" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" />
                        <asp:BoundField DataField="AttendanceDate" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" />
                        <asp:BoundField DataField="IsPresent" HeaderText="Present?" />
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                    </Columns>

                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
            </td>
        </tr>

    </table>

</asp:Content>
