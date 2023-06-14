<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication20.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    transaction form</p>
<p>
    &nbsp;</p>
<p>
    <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" Text="issue" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton1_CheckedChanged" />
    <asp:RadioButton ID="RadioButton2" runat="server" Text="purchase" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton2_CheckedChanged" />
</p>
<p>
    item Name :<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="item_name" DataValueField="item_id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:trustdb1ConnectionString %>" ProviderName="<%$ ConnectionStrings:trustdb1ConnectionString.ProviderName %>" SelectCommand="SELECT [item_id], [item_name] FROM [item_master]"></asp:SqlDataSource>
</p>
    <p>
        date
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
</p>
    <p>
    &nbsp;<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:trustdb1ConnectionString %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
</p>
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label3" runat="server" Text="department name"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Department_name" DataValueField="Department_id">
        </asp:DropDownList>
        
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="Label2" runat="server" Text="vendor name"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="Vendor_name" DataValueField="Vendor_id">
            </asp:DropDownList>
        </asp:Panel>
    <p>
</p>
    <p>
    &nbsp;
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:trustdb1ConnectionString %>" SelectCommand="SELECT [Vendor_id], [Vendor_name] FROM [Vendor_mast]"></asp:SqlDataSource>
</p>
    <p>
        quantity&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="save" OnClick="Button1_Click" Width="183px" />
</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
