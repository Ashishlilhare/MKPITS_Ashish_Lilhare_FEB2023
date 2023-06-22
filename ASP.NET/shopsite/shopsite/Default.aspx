<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="shopsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Shop today Pay Tommarow</h1>
            <p style="border: 0px solid rgb(217, 217, 227); box-sizing: border-box; --tw-border-spacing-x: 0; --tw-border-spacing-y: 0; --tw-translate-x: 0; --tw-translate-y: 0; --tw-rotate: 0; --tw-skew-x: 0; --tw-skew-y: 0; --tw-scale-x: 1; --tw-scale-y: 1; --tw-pan-x: ; --tw-pan-y: ; --tw-pinch-zoom: ; --tw-scroll-snap-strictness: proximity; --tw-gradient-from-position: ; --tw-gradient-via-position: ; --tw-gradient-to-position: ; --tw-ordinal: ; --tw-slashed-zero: ; --tw-numeric-figure: ; --tw-numeric-spacing: ; --tw-numeric-fraction: ; --tw-ring-inset: ; --tw-ring-offset-width: 0px; --tw-ring-offset-color: #fff; --tw-ring-color: rgba(69,89,164,.5); --tw-ring-offset-shadow: 0 0 transparent; --tw-ring-shadow: 0 0 transparent; --tw-shadow: 0 0 transparent; --tw-shadow-colored: 0 0 transparent; --tw-blur: ; --tw-brightness: ; --tw-contrast: ; --tw-grayscale: ; --tw-hue-rotate: ; --tw-invert: ; --tw-saturate: ; --tw-sepia: ; --tw-drop-shadow: ; --tw-backdrop-blur: ; --tw-backdrop-brightness: ; --tw-backdrop-contrast: ; --tw-backdrop-grayscale: ; --tw-backdrop-hue-rotate: ; --tw-backdrop-invert: ; --tw-backdrop-opacity: ; --tw-backdrop-saturate: ; --tw-backdrop-sepia: ; margin: 1.25em 0px; color: rgb(0, 0, 0); font-family: Söhne, ui-sans-serif, system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, Ubuntu, Cantarell, &quot;Noto Sans&quot;, sans-serif, &quot;Helvetica Neue&quot;, Arial, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: pre-wrap; background-color: #FFFFFF; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">
                Discover the ultimate shopping experience with our exclusive offer: &quot;Shop Today, Pay Tomorrow!&quot; Indulge in your favorite products without worrying about immediate payment. With our flexible payment options, you can enjoy the convenience of shopping now and settling your bill later. It&#39;s time to treat yourself to the things you love without breaking the bank!</p>
            <br class="Apple-interchange-newline" />
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h1 class="sc-jSUZER brXxlr" color="greyBase" font-size="48px" font-weight="bold" style="padding: 0px; margin: 0px; box-sizing: border-box; font-size: 48px; color: rgb(53, 53, 67); font-style: normal; font-weight: 700; line-height: 52px; font-family: &quot;Mier bold&quot;; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: 0.5px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"><span class="VideoBanner__TextUnderline-sc-149azki-3 demnYS" style="padding: 0px; margin: 0px; box-sizing: border-box; display: inline-block; position: relative; z-index: 1;">Low</span><span style="padding: 0px; margin: 0px; box-sizing: border-box;">est Prices<br style="padding: 0px; margin: 0px; box-sizing: border-box;" />
                    Best Quality Shopp</span><span class="VideoBanner__TextUnderline-sc-149azki-3 demnYS" style="padding: 0px; margin: 0px; box-sizing: border-box; display: inline-block; position: relative; z-index: 1;">ing</span></h1>
                <h2 id="gettingStartedTitle">&nbsp;</h2>
                <p>
                    Become a Resellar and
                </p>
                <p>
                    Start Your Online Business with Zero Investment</p>
                <p>
                    &nbsp;</p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Cash on Delivery</h2>
                <p>
                    Free cash on delivery facilty Available on your city.</p>
                <p>
                    &nbsp;</p>
                                    <a class="btn btn-default" href="https://www.meesho.com/">Learn more &raquo;</a>

                <p>
                    &nbsp;</p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <p>
                    <img src="m1.jpg" style="width:450px;height:350px;" />
                </p>
                <p>
                </p>
            </section>
        </div>
    <br />
   <h1 align=center>------------------ Top Categories to choose from ---------------</h1>

        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="100%" RepeatDirection="Horizontal" BackColor="#CCCCCC" BorderColor="Blue" BorderStyle="Ridge" BorderWidth="5px" CellPadding="4" CellSpacing="2" ForeColor="Black" GridLines="Both">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="White" />
                <ItemTemplate>  
                <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;   
                border: dashed 0px #04AFEF; background-color: #FFFFFF">  
                    <tr>  
                        <td align="center">  
                             <a href='<%# Eval("prodid","productdetails.aspx?prodid={0}") %>'>

                             <asp:Image ID="img1" ImageUrl='<%# Bind("prodimage", "~/img/{0}") %>' runat="server" Height="100"
                        Width="100" />
                            
                              
                        </td>  
                    </tr>  

                    <tr>
                        <td align="center">
                            <span > <%# Eval("prodname") %></span><br /> 
                             <span > <%# Eval("proddescription") %></span><br /> 
                             <span >₹ <%# Eval("prodprice") %> onwards</span><br /> 
                            

                        </td>
                    </tr>
                </table>  
            </ItemTemplate>  
                <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />

            </asp:DataList>
        </div>

    </main>

</asp:Content>