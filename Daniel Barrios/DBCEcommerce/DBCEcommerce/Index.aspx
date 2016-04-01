<%@ Page Title="" Language="C#" MasterPageFile="~/DBCMasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DBCEcommerce.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text=""  ></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </div>
</asp:Content>
