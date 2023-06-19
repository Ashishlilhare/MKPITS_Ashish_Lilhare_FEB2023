<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Itemmaster.aspx.cs" Inherits="Drivenit.Itemmaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>ItemMaster</strong></p>
    <p>
        ItemDescr<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        BalQty<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    CreatedOn<asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
