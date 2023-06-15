<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="storemanagment.Vendor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>vendor master</strong></p>
    <p>
        vendor Id<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        vendor name
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <asp:Button ID="Button2" runat="server" Text="modify" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
