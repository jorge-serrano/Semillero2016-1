<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DBCommerceLogin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        DECommerce<br />
        <br />
        User<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    
    </div>
        Pass<asp:TextBox ID="txtPassWord" runat="server" TextMode="Password" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <div style="margin-left: 80px">
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <div style="margin-left: 120px">
        </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" class="btn btn-primary" />
       

        <br />
        <br />
        <br />
        <br />
        <div style="margin-left: 40px">
        </div>
        <br />
    </form>
</body>
</html>
