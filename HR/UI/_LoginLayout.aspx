<%@ Page Language="C#" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }
        .login-box {
            width: 350px;
            margin: 120px auto;
            background: white;
            padding: 25px;
            box-shadow: 0 0 10px #999;
        }
        input, button {
            width: 100%;
            padding: 8px;
            margin-top: 8px;
        }
        button {
            background: #007bff;
            color: white;
            border: none;
        }
        .error {
            color: red;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="login-box">
            <asp:ContentPlaceHolder ID="MainContent" runat="server" />
        </div>
    </form>
</body>
</html>
