<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="trustmachinetest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-size: xx-large;
        }
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 62%;
            height: 45px;
        }
        .auto-style4 {
            width: 520px;
        }
        .auto-style5 {
            width: 130px;
        }
        .auto-style6 {
            width: 129px;
        }
        .auto-style7 {
            width: 410px;
        }
        .auto-style8 {
            width: 95%;
        }
        .auto-style9 {
            width: 137px;
        }
        .auto-style10 {
            text-align: center;
            width: 1063px;
        }
        .auto-style11 {
            width: 51%;
            margin-left: 139px;
        }
        .auto-style12 {
            text-align: center;
            width: 209px;
        }
        .auto-style13 {
            width: 344px;
        }
        .auto-style14 {
            width: 61%;
        }
        .auto-style15 {
            width: 268px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style10">
            <strong class="newStyle1">Store Managment System<br />
            </strong>
        </div>
        <table>
            <tr>
                <td class="auto-style4">
                    <asp:Panel ID="Panel1" runat="server" Width="509px">
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style1" colspan="2"><strong>Item Entry</strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Item Id</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Item name</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Category</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Rate</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">Balance quantity</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td rowspan="2">
                    <asp:Panel ID="Panel2" runat="server" Height="160px" Width="572px">
                        <table class="auto-style8">
                            <tr>
                                <td class="auto-style1" colspan="2"><strong>Vendor</strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Vendor id</td>
                                <td class="auto-style7">
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">Vendor name</td>
                                <td class="auto-style7">
                                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" rowspan="2">
                    <table class="auto-style14">
                        <tr>
                            <td class="auto-style1" colspan="2"><strong>Department</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style15">Department id</td>
                            <td class="auto-style13">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style15">Department Name</td>
                            <td class="auto-style13">
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style13">&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel3" runat="server">
                        <table class="auto-style2">
                            <tr>
                                <td class="auto-style1" colspan="2"><strong>Transaction</strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Transaction id</td>
                                <td>
                                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Transaction date</td>
                                <td>
                                    <asp:TextBox ID="TextBox11" runat="server" TextMode="Date"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Quantity</td>
                                <td>
                                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
        <table align="left" class="auto-style11">
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Add" Width="54px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button2" runat="server" Text="Modify" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button3" runat="server" Text="Delete" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button4" runat="server" Text="Search" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
