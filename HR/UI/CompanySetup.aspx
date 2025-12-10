<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanySetup.aspx.cs" 
    Inherits="HR.UI.CompanySetup" MasterPageFile="~/HRSite.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 149px;
            height: 29px;
        }
        .auto-style3 {
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
            width: 668px;
        }
        .auto-style5 {
            width: 668px;
        }
    </style>

    <div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Company Name:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtCompanyAddress" runat="server" OnTextChanged="txtCompanyAddress_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtCompanyEmail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:GridView ID="grdShow" runat="server" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    </div>
</asp:Content>




<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanySetup.aspx.cs" Inherits="HR.UI.CompanySetup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 149px;
        }
        .auto-style2 {
            width: 149px;
            height: 29px;
        }
        .auto-style3 {
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
            width: 668px;
        }
        .auto-style5 {
            width: 668px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Company Name:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblCompanyName" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtCompanyAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblCompanyAddress" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnShowAddress" runat="server" OnClick="btnShowAddress_Click" Text="Show" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Contact:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtCompanyContact" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblCompanyContact" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnShowContact" runat="server" OnClick="btnShowContact_Click" Text="Show" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtCompanyEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblCompanyEmail" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnShowEmail" runat="server" OnClick="btnShowEmail_Click" Text="Show" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Established:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtCompanyEstablished" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblCompanyEstablished" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnShowEstablished" runat="server" OnClick="btnShowEstablished_Click" Text="Show" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>--%>

