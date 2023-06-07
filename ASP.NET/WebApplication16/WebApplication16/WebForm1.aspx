<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cookie<br />
            <br />
            <br />
            Enter username<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="store in temp cookie" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show temp Cookies" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
