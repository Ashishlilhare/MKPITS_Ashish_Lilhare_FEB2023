<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="WebApplication20.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
        <table __designer:mapid="18" class="auto-style8" align="center">
            <tr __designer:mapid="1f">
                <td __designer:mapid="20" colspan="2"><strong __designer:mapid="21">Vendor</strong></td>
            </tr>
            <tr __designer:mapid="22">
                <td __designer:mapid="23" class="auto-style6">Vendor id</td>
                <td __designer:mapid="24" class="auto-style7">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr __designer:mapid="26">
                <td __designer:mapid="27" class="auto-style6">Vendor name</td>
                <td __designer:mapid="28" class="auto-style7">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
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
    <p class="text-center">
        <br />
    </p>
</asp:Content>
