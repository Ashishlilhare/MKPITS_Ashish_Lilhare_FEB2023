<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication20.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        vendor master</p>
    <p>
        vendor_id&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="search" />
    </p>
    <p>
        vendor name <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modify" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="delete" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
