<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication9.WebForm1" %>

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
            width: 248px;
            text-align: left;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            width: 248px;
            text-align: left;
            height: 25px;
        }
        .auto-style6 {
            text-align: left;
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div class="auto-style1">
            <strong>Registration Form</strong></div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Name </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Address</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Mobile No.</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">DOB</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Gender</td>
                    <td class="auto-style6">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Hobbies</td>
                    <td class="auto-style4">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Cricket" />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Reading" />
                        <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Writing" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">City</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Nagpur</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Nashik</asp:ListItem>
                            <asp:ListItem>Pune </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
