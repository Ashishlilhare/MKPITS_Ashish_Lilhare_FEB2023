<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication18.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            product id<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            product type id
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            product name
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            price
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="insert " />
            &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="search" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
