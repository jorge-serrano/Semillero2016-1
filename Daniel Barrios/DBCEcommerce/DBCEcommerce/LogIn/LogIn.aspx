<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="DBCEcommerce.LogIn.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div align="center">
        <br /><br />
    <form id="form1" runat="server">
    <div>
    <table>
        <tr> 
            <td> User
            </td>
            <td>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr> 
            <td> Password
            </td>
            <td>
                <asp:TextBox ID="keyword" runat="server" Type="password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:Button ID="LoginInButton" runat="server" Text="Sign In" OnClick="LoginInButton_Click" style="color:black;background-color:white;border-radius:5px;margin-left:200%;"/>
                
            </td>
        </tr>
        <asp:Label ID="Label1" runat="server" Text=""  ></asp:Label>
    </table>
    </div>
    </form>
        </div>
</body>
</html>
