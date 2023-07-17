<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.Models.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 59px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:bike_storeConnectionString %>" ProviderName="<%$ ConnectionStrings:bike_storeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [sheet]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Height="413px" Width="252px">
            <Columns>
                <asp:BoundField DataField="EMPLOYEE_ID" HeaderText="EMPLOYEE_ID" SortExpression="EMPLOYEE_ID" />
                <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
                <asp:BoundField DataField="LAST_NAME" HeaderText="LAST_NAME" SortExpression="LAST_NAME" />
                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                <asp:BoundField DataField="PHONE_NUMBER" HeaderText="PHONE_NUMBER" SortExpression="PHONE_NUMBER" />
                <asp:BoundField DataField="HIRE_DATE" HeaderText="HIRE_DATE" SortExpression="HIRE_DATE" />
                <asp:BoundField DataField="JOB_ID" HeaderText="JOB_ID" SortExpression="JOB_ID" />
                <asp:BoundField DataField="SALARY" HeaderText="SALARY" SortExpression="SALARY" />
                <asp:BoundField DataField="COMMISSION_PCT" HeaderText="COMMISSION_PCT" SortExpression="COMMISSION_PCT" />
                <asp:BoundField DataField="MANAGER_ID" HeaderText="MANAGER_ID" SortExpression="MANAGER_ID" />
                <asp:BoundField DataField="DEPARTMENT_ID" HeaderText="DEPARTMENT_ID" SortExpression="DEPARTMENT_ID" />
                <asp:BoundField DataField="F12" HeaderText="F12" SortExpression="F12" />
                <asp:BoundField DataField="F13" HeaderText="F13" SortExpression="F13" />
                <asp:BoundField DataField="F14" HeaderText="F14" SortExpression="F14" />
                <asp:BoundField DataField="F15" HeaderText="F15" SortExpression="F15" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
