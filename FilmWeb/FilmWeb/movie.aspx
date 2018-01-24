<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movie.aspx.cs" Inherits="GYFilmWeb.movie" MasterPageFile="~/FilmMaster.Master" %>


<asp:Content runat="server" ID="deafult" ContentPlaceHolderID="ContentPlaceHolder1">
        <asp:Repeater ID="dgdShowFilm" runat="server" OnItemCommand="dgdShowFilm_ItemCommand">

            <ItemTemplate>
            <div>
        <div id="body" class="movies">
		<ul>
		<li>
				<a>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Image/Film/"+Eval("ISBN")+".jpg" %>' /></a>
				<h3><a><%# Eval("FTitle") %></a></h3>
				</li>
            
			<li >
				<h3 > 电 影 类 型</h3>
				<p> <%# Eval("FTypeName") %></p>
			</li>
			<li >
				<h3>上 映 时 间</h3>
				<p><%# Eval("PublishDate") %></p>
			</li>
			<li>
				<h3>剧 情 简 介</h3>
				<p><%# Eval("FDesc") %></p>
			</li>
			<li>
				<h3>演 职 人 员</h3><p> <%# Eval("Actor") %></p>
			</li>
			<li >
				<h3>电 影 价 格</h3>
                <p style="font-size:15px;color:cyan"> <%# Eval("FPrice","{0:C}") %></p>
            	<li>
				<h3><asp:Button ID="addShopCar" runat="server" Text="加入购物车..." CommandName='<%# Eval("FID") %>'/></h3>
				</li>
			</li>
		</ul>
	</div>
    </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                
     <div>
        <div id="body" class="movies">	<ul>
		<li>
				<a>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Image/Film/"+Eval("ISBN")+".jpg" %>' /></a>
				<h3><a><%# Eval("FTitle") %></a></h3>
				</li>
            
			<li >
				<h3 > 电 影 类 型</h3>
				<p> <%# Eval("FTypeName") %></p>
			</li>
			<li >
				<h3>上 映 时 间</h3>
				<p><%# Eval("PublishDate") %></p>
			</li>
			<li>
				<h3>剧 情 简 介</h3>
				<p><%# Eval("FDesc") %></p>
			</li>
			<li>
				<h3>演 职 人 员</h3><p> <%# Eval("Actor") %></p>
			</li>
			<li >
				<h3 >电 影 价 格</h3>
                <p style="font-size:15px;color:cyan"> <%# Eval("FPrice","{0:C}") %></p>
            	<li>
				<h3><asp:Button ID="addShopCar" runat="server"  Text="加入购物车..." CommandName='<%# Eval("FID") %>'/></h3>
				</li>
			</li>
		</ul>

	</div>
    </div>
		
            </AlternatingItemTemplate>
        </asp:Repeater>
    
               <div style="text-align:center">
                   <br />
                   <br />
               <asp:Button ID="btnPre" runat="server" Text="上一页" OnClick="btnPre_Click" Font-Bold="True" />
                  <span class="ye"> &nbsp; 第[ <strong><asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                   </strong>]页/共[<strong><asp:Label ID="lblCuont" runat="server" ></asp:Label></strong>]页&nbsp; </span><asp:Button ID="Button2" runat="server" Text="下一页" OnClick="Button2_Click" Font-Bold="True" style="height: 21px" />

               </div>
        <br />
   
    <style>
        .ye {
            color:white;
            background-color:black;
        }
    </style>
</asp:Content>
