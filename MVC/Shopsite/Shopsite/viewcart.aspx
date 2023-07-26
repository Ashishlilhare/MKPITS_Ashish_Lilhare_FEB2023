<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewcart.aspx.cs" Inherits="Shopsite.viewcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <center>
           <h1> your cart</h1>
        </center>
          <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal"      
      RepeatColumns="1" Width="100%"   >
 <HeaderTemplate>      
                        <table style="width:100%;" border="1">      
                            <tr>      
                                <th style="width:20%;">      
                                    product id      
                                </th> 
                                 <th style="width:20%;">      
                                    product name      
                                </th> 
                             
                                 <th style="width:20%;">      
                                    product image   
                                </th> 
                                 <th style="width:20%;">      
                                    product price    
                                </th> 
                                  <th style="width:10%;">      
                                    quantity   
                                </th> 
                                  <th style="width:10%;">      
                                   total amount    
                                </th> 
                            </tr>      
                        </table>      
                    </HeaderTemplate>  
          
            <ItemStyle CssClass="itemstyle" />      
                           <ItemTemplate>   
                        <table style="width:100%;" align="center" style="border-spacing:20px;padding:20px;">
                            <tr>
                               <td align="center" style="width:20%;">  
                                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("prodid") %>' visible="true">

                                                </asp:Label>
                                   </td>
                                   <td align="center" style="width:20%;">  
                                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("prodname") %>' visible="true">

                                                </asp:Label>
                                   </td>
                                 
                                   <td align="center" style="width:20%;">  
                                              <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl='      
                                        <%# "~/Images/" + Eval("prodimage") %>' Height="50px" Width="50px" />  
                                   </td>
                                 <td align="center" style="width:20%;">  
                                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("prodprice") %>' visible="true">

                                                </asp:Label>
                                   </td>
                                    <td align="center" style="width:10%;">  
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("quantity") %>' visible="true">

                                                </asp:Label>
                                   </td>
                                    <td align="center" style="width:10%;">  
                                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("totalprice") %>' visible="true">

                                                </asp:Label>
                                   </td>

                                </tr>
                            </table>
                        </ItemTemplate>

            

       </asp:DataList>
<br /><br />
<center>
        <asp:Button ID="Button1" runat="server" Text="add more items" OnClick="Button1_Click1" />
    </center>
<p align="right">
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
</p>
    </div>

</asp:Content>
