<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="WebApplication20.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <strong>Item Entry<br />
        <table __designer:mapid="0" align="center" class="auto-style3">
            <tr __designer:mapid="7">
                <td __designer:mapid="8" class="auto-style5" style="width: 393px">Item Id</td>
                <td __designer:mapid="3" class="text-start" style="width: 541px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="4">
                <td __designer:mapid="5" class="auto-style5" style="width: 393px; height: 27px">Item name</td>
                <td __designer:mapid="6" class="text-start" style="width: 541px; height: 27px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="9">
                <td __designer:mapid="a" class="auto-style5" style="width: 393px">Category</td>
                <td __designer:mapid="b" class="text-start" style="width: 541px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Electronics</asp:ListItem>
                        <asp:ListItem>Consumable</asp:ListItem>
                        <asp:ListItem>Furniture</asp:ListItem>
                        <asp:ListItem Value="Stationary"></asp:ListItem>
                        <asp:ListItem>Grocery</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr __designer:mapid="c">
                <td __designer:mapid="d" class="auto-style5" style="width: 393px">Rate</td>
                <td __designer:mapid="e" class="text-start" style="width: 541px">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="f">
                <td __designer:mapid="10" class="auto-style5" style="width: 393px">Balance quantity</td>
                <td __designer:mapid="11" class="text-start" style="width: 541px">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        </strong>
    </p>
    <p class="text-center">
        <table align="left" class="auto-style11">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="54px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modify" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Load data" />
    </p>
    <p class="text-start">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="text-center">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
