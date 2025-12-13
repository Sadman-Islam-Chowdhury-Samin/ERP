<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="User.aspx.cs"
    Inherits="HR.UI.User"
    MasterPageFile="~/LoginMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background-color: #f4f6f9;
            font-family: Arial, Helvetica, sans-serif;
        }

        .login-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 80vh;
        }

        .login-box {
            width: 350px;
            padding: 25px;
            background-color: #ffffff;
            border-radius: 6px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.15);
        }

        .login-box h2 {
            text-align: center;
            margin-bottom: 20px;
            color: #333;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .form-control {
            width: 100%;
            padding: 8px;
            border-radius: 4px;
            border: 1px solid #ccc;
        }

        .btn-login {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            border: none;
            color: white;
            font-size: 16px;
            border-radius: 4px;
            cursor: pointer;
        }

        .btn-login:hover {
            background-color: #0056b3;
        }

        .error-message {
            text-align: center;
            margin-top: 10px;
            color: red;
        }
    </style>

    <div class="login-container">
        <div class="login-box">

            <h2>User Login</h2>

            <div class="form-group">
                <label>Username</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
            </div>

            <div class="form-group">
                <label>Password</label>
                <asp:TextBox ID="txtPassword" runat="server" 
                             TextMode="Password" CssClass="form-control" />
            </div>

            <asp:Button ID="btnLogin" runat="server"
                Text="Login"
                CssClass="btn-login"
                OnClick="btnLogin_Click" />

            <asp:Label ID="lblMessage" runat="server" CssClass="error-message" />

        </div>
    </div>

</asp:Content>
