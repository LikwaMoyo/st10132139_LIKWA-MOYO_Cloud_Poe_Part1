<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccountPage.aspx.cs" Inherits="Cloud_Poe_PartOne.CreateAccountPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Create Account</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <style>
        body {
            background-color: #f9f9f9;
            font-family: Arial, sans-serif;
        }
        .container {
            max-width: 600px;
            margin-top: 50px;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }
        .form-group label {
            font-weight: bold;
        }
        .btn-primary {
            background-color: #007bff;
            border: none;
        }
        .btn-primary:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="text-center">Create Account</h2>
            <div class="form-group">
                <label for="username">Username</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter username"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email address</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="role" class="sr-only">Select user role</label>
                <select id="SlRole" runat="server" class="form-control">
                    <option value="Buyer">Buyer</option>
                    <option value="Seller">Seller</option>
                </select>
            </div>
            <div class="form-group">
                <label for="phoneNumber">Phone number</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" placeholder="Enter phone number"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter password"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="confirmPassword">Confirm Password</label>
                <asp:TextBox ID="confirmPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Confirm password"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnCreateAccount" runat="server" CssClass="btn btn-primary btn-block" Text="Create Account" OnClick="btnCreateAccount_Click" />
            </div>
            <div class="text-center mt-3">
                <asp:LinkButton ID="Login" runat="server" OnClick="LinkButton1_Click" CssClass="btn btn-link">Already have an account? Login!</asp:LinkButton>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
