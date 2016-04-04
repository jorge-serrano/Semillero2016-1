<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ecommerce.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
            <div align="center">
            <div class="text_box">
                <div class="title" >Clients login </div>
                <div class="login_form_row">
                    <label class="login_label">Username:</label>
                    <asp:TextBox ID="TextUser" runat="server"></asp:TextBox>
                </div>
                            
                <div class="login_form_row">
                    <label class="login_label">Password:</label>
                    <asp:TextBox ID="TextPasword" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="ButSubmit" runat="server" Text="Submit" OnClick="ButSubmit_Click" CssClass="center"/>  
            </div>           
            <asp:Label ID="LblMesagge" runat="server" Text="LblMessage" Visible="False"></asp:Label>
       </div>
</asp:Content>
