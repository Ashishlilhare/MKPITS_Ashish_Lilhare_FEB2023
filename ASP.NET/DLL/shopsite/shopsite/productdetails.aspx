<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="productdetails.aspx.cs" Inherits="shopsite.productdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<style>
  table,  th, td {
  padding: 15px;
  border: 1px solid lightgray;
  border-collapse: collapse;
}
</style>
    <asp:DataList ID="DataList1" runat="server" Width="100%" RepeatColumns="1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
        <ItemTemplate>
           <table cellpadding="2" cellspacing="0" border="1" style="width: 100%; height: 400px;   
                border: dashed 0px #04AFEF; background-color: #FFFFFF">  
                    <tr>
                        <td>
                        <table width="100%">
                            <tr>
                                 <td align="center" >
                                     <a href='<%# Eval("prodid","productdetails.aspx?prodid={0}") %>'>
                                     <asp:Image ID="img1" ImageUrl='<%# Bind("prodimage", "~/img/{0}") %>' runat="server" Height="250"
                                    Width="200"   />
                                     </a>
                                  </td>  
                             </tr>
                             <tr align="center">
                                <td>
                                    <a style="border=1;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;" href="cart.aspx" >Add To Cart</a>
                                    &nbsp;&nbsp;
                                    <a style="border=1;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;" href="cart.aspx" >Buy Now</a>
                                </td>
                               
                             </tr>
                            </table>
                    </td>
                        <td >

                            <table width="100%"  >
                                <tr>
                                    <td >
                            <span ><b> <%# Eval("prodname") %></b></span><br /> 
 <span >Rs. <%# Eval("prodprice") %> onwards</span><br /> <br />
                            Free Delivery
                                        </td>
                                    </tr>
                            <tr>
                                <td>
                            <b>Product Details</b>
                                    Name : <%# Eval("prodname") %> <br />
                                    Description : <%# Eval("proddescription") %> <br />
                                    Size : M, L ,XL, XXL </br>
                                    Country of origin : India
                                    </td>
                                </tr>

                                </table>

                        </td>
                    </tr>
                </table>

        </ItemTemplate>
    </asp:DataList>
</asp:Content>

