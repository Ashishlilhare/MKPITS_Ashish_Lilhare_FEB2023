<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #FF0066;
            text-decoration: underline;
        }
        .newStyle1 {
            font-family: "Cascadia Code";
        }
        .auto-style2 {
            width: 100%;
        }
        .newStyle2 {
        }
        .auto-style3 {
            width: 329px;
        }
        .auto-style4 {
            width: 329px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong class="newStyle1">Age Criteria checker for vote</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4"><strong>Age </strong></td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Result</strong></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
