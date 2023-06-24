<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="shopsite.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>Signup To save Your order<br />
        </strong>
    </p>
    <p class="text-center">
        <strong>Enter mobile No.<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </strong>
    </p>
    <p class="text-center">
        <strong>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-top: 7" Text="Continue" />
        </strong>
    </p>
    <p>
    </p>
</asp:Content>
