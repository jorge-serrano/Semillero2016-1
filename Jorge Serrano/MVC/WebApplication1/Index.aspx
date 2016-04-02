<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="User "></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
        <div>
        <asp:Label ID="Label2" runat="server" Text="Password "></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
    <script src="Scripts/Utils.js"></script>
    <script src="Scripts/jquery-2.2.2.min.js"></script>
</body>
</html>
