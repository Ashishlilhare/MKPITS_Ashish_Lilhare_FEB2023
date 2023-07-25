<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="proddetails.aspx.cs" Inherits="Shopsite.proddetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <div class="text-center">

          <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal"      
      RepeatColumns="4" Width="100%"   >

 <HeaderTemplate>      
                        <table>      
                            <tr>      
                                <td>      
                                    <h1>Product for you</h1>      
                                </td>      
                            </tr>      
                        </table>      
                    </HeaderTemplate>  

            <ItemStyle CssClass="itemstyle" />      
                    <ItemTemplate>   
                        <table align="center" style="border-spacing:20px;padding:20px;">
                            <tr>
                               <td>
                                    <table border="0" style="border-spacing:20px;padding:20px;" >      
                                        <tr>     
                                            <td style="padding:20px;" >  
                                                  <asp:Label ID="lblprodimage" runat="server" text='      
                                        <%# Eval("prodimage") %>' visible="false" />      
                                            </td>  
                                    <asp:ImageButton ID="prodimg" runat="server" ImageUrl='      
                                        <%# "~/Images/" + Eval("prodimage") %>' Height="180px" Width="200px" />      
                                            </td>  
                                
                                           <td  style="padding:20px;" >
                                               <table style="border-spacing:20px;">
                                                   <tr>
                                            <td align="center">      
                                                <asp:Label ID="lblproddescription" runat="server" Text='<%# Eval("proddescription") %>'>      
                                                </asp:Label>      
                                            </td>  
                                                       </tr>

                                                       <tr>
                                            <td align="center">      
                                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("prodname") %>'>      
                                                </asp:Label>      
                                            </td>  
                                                       </tr>
                                                   <tr>
                                      
                                            <td align="center">  
                                                <asp:Label ID="lblprodid" runat="server" Text='<%# Eval("prodid") %>' visible="false">

                                                </asp:Label>
                                          Price :     <asp:Label ID="lblprodprice" runat="server" Text='<%# Eval("prodprice") %>'>      
                                                </asp:Label>  Rs.    
                                            </td> 
                                                       </tr>

                                                     <tr>     
                                            <td >      
                                    <asp:Button OnClick="Button1_Click"   ID="ImageButton1" runat="server" Text="Add To Cart" Height="50px" Width="200px" />      
                                            </td>  
                                                            <td >      
                                    <asp:Button OnClick="Button2_Click"   ID="Button2" runat="server" Text="view cart" Height="50px" Width="200px" />      
                                            </td>  
                                
                                
                                        </tr>        
                                                   </table>
                                               </td>
                                 
                                        </tr>      
                                
                                          
                                    </table>  
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate> 

       </asp:DataList>


    </div>
</asp:Content>
