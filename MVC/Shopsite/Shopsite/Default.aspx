<%@ Page EnableEventValidation="false" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Shopsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>My Shop Site</h1>
        <p class="lead">My shop site for good buying experience.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg" style="width: 297px; height: 20px">Learn more &raquo;</a></p>
    </div>

     <div>
   
       <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Horizontal"      
      RepeatColumns="4" Width="100%"  OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged"  >
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
                        <table align="center">
                            <tr>
                               <td>
                                    <table border="0" >      
                                        <tr>     
                                            <td >      
                                    <asp:ImageButton OnClick="Button1_Click"  ID="prodimg" runat="server" ImageUrl='      
                                        <%# "~/Images/" + Eval("prodimage") %>' Height="180px" Width="200px" />      
                                            </td>  
                                
                                        </tr>      
                                        <tr>         
                                            <td align="center">      
                                                <asp:Label ID="lblprodname" runat="server" Text='<%# Eval("prodname") %>'>      
                                                </asp:Label>      
                                            </td>      
                                        </tr>      
                                        <tr>      
                                       
                                            <td align="center">  
                                                <asp:Label ID="lblprodid" runat="server" Text='<%# Eval("prodid") %>' visible="false">

                                                </asp:Label>
                                               <span>₹</span><asp:Label ID="lblprodprice" runat="server" Text='<%# Eval("prodprice") %>'>      
                                                </asp:Label>      
                                            </td>  
                                 
                                        </tr>      
                                
                                          
                                    </table>  
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate> 

       </asp:DataList>
   </div>
  
    <hr />

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
