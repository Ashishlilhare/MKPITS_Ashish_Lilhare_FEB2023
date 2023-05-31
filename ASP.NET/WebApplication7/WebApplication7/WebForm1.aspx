<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 170px;
        }
        .auto-style5 {
            height: 23px;
            width: 170px;
        }
        .auto-style6 {
            width: 145px;
        }
        .auto-style7 {
            width: 145px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Calculator</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">Number1</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Number2</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADDITION" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Substraction" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiplication" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Division" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Result</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <p>
        <hr />
        <table class="auto-style2">
            <tr>
                <td class="auto-style7">Number1</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Number2</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Oprators</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="OK" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Result</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
