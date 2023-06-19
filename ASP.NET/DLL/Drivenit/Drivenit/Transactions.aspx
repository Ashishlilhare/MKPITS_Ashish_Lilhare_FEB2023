<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="Drivenit.Transactions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center">
    <strong>Transactions form</strong></p>
<table class="w-100">
    <tr>
        <td style="width: 176px">Item ID</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemDescr" DataValueField="ItemID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenitDBConnectionString %>" SelectCommand="SELECT [ItemDescr], [ItemID] FROM [ItemMaster]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td style="width: 176px; height: 22px">Transactions type</td>
        <td style="height: 22px">
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="tt" Text="Issue" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="tt" Text="received" />
        </td>
    </tr>
    <tr>
        <td style="width: 176px">Transactions quantity</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 176px">Transactions Date</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
</table>
<p>
    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TransID" DataSourceID="SqlDataSource2" Width="777px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="TransID" HeaderText="TransID" InsertVisible="False" ReadOnly="True" SortExpression="TransID" />
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
                <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
                <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
                <asp:BoundField DataField="TransDate" HeaderText="TransDate" SortExpression="TransDate" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenitDBConnectionString2 %>" DeleteCommand="DELETE FROM [Transactions] WHERE [TransID] = @TransID" InsertCommand="INSERT INTO [Transactions] ([ItemID], [TransType], [TransQty], [TransDate]) VALUES (@ItemID, @TransType, @TransQty, @TransDate)" ProviderName="<%$ ConnectionStrings:DrivenitDBConnectionString2.ProviderName %>" SelectCommand="SELECT [TransID], [ItemID], [TransType], [TransQty], [TransDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemID] = @ItemID, [TransType] = @TransType, [TransQty] = @TransQty, [TransDate] = @TransDate WHERE [TransID] = @TransID">
            <DeleteParameters>
                <asp:Parameter Name="TransID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ItemID" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ItemID" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
                <asp:Parameter Name="TransID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</p>
    <p>
        &nbsp;</p>
</asp:Content>
