<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopCar.aspx.cs" Inherits="GYFilmWeb.ShopCar" MasterPageFile="~/FilmMaster.Master" %>
<asp:Content runat="server" ID="shopcar" ContentPlaceHolderID ="ContentPlaceHolder1">
<div style="text-align:center;">
      <br /><br />
        <p>
            <span style="font-size:40px; color:aqua;font-weight:800">购物车</span>
        </p>
            <table style="padding: 5px; width: 100%; height:100%; background-color :#94AAD6;">
            <asp:Repeater ID="dgdShowFilm" runat="server" OnItemCommand="dgdShowFilm_ItemCommand" >
                <ItemTemplate  >                    
                    <tr>
                        <td style="width: 110px;border:2px dotted red;">
                            <asp:Image ID="imgCover" Height="200px" Width="130px" ImageUrl='<%# "~/Image/Film/"+Eval("Cover")+".jpg" %>'
                                runat="server"  />
                        </td>
                        <td style="text-align:center;border:2px dotted black;">
                            <%# Eval("Title") %></td>
                        <td style="text-align:center;border:2px dotted black;">
                            <%# Eval("Price","{0:C}") %>
                        </td>
                        <td style="text-align:center;border:2px dotted black;"">
                            <asp:Button ID="btnCut" runat="server" Text="-" CommandName="Cut" CommandArgument='<%# Eval("FilmID") %>' />
                            <asp:TextBox ID="txtPrice" Text='<%# Eval("Count") %>' runat="server" Width="30"></asp:TextBox>
                            <asp:Button ID="btnAdd" runat="server" Text="+" CommandName="Add" CommandArgument='<%# Eval("FilmID") %>' />
                        </td>
                        <td style="text-align: center;border:2px dotted black;"">
                            <asp:LinkButton ID="btnBuy" CommandArgument='<%# Eval("FilmID") %>' CommandName="Delete" OnClientClick="return confirm('从购物车中移除？');" runat="server">删除</asp:LinkButton>
                        </td>
                    </tr>            
                </ItemTemplate>
            </asp:Repeater>
                <tr>
                    <td colspan="5" style="text-align:right">
                        <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5" style="text-align:right">
                        <asp:Button ID="btnOrder" runat="server" Text="生成订单" OnClick="btnOrder_Click" />
                    </td>
                </tr>
                </table>
        <p>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Text="" />
            </p>
    </div>

</asp:Content>