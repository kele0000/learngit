<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GYFilmWeb.index" MasterPageFile="~/FilmMaster.Master" %>

<asp:Content runat="server" ID="deafult" ContentPlaceHolderID="ContentPlaceHolder1">
        <div id="myFocus">
            <!--焦点图盒子-->
            <div class="pic">
                <!--图片列表-->
                <ul>
                        <li>
                            <a href="movie.aspx"><img src="images/勇敢者游戏.jpg" thumb="" alt=" 勇敢者游戏：决战丛林 "/></a>
                        </li>
                        <li>
                            <a href="movie.aspx"><img src="images/前任3再见.jpg" thumb="" alt="前任3:再见"  /></a>
                        </li>
                        <li>
                            <a href="movie.aspx"><img src="images/寻梦环游记.jpg" thumb=""  alt="寻梦环游记"  /></a>
                        </li>
                        <li>
                            <a href="movie.aspx"><img src="images/英雄本色2018.jpg" thumb="" alt="英雄本色2018"   /></a>
                        </li>
                        <li>
                            <a href="movie.aspx"><img src="images/芳华.jpg" thumb="" alt="芳华" /></a>
                        </li>
                    </ul>
            </div>
        </div>
    
    <div id="body" class="home">
		<div>
			<div>
				<a href="movie.aspx"><img src="image/Film/20171019100.jpg" alt=""></a>
				<h2><a href="movie.aspx">王牌特工2：黄金圈</a></h2>
				<p>
					本片讲述了艾格西（塔伦·埃格顿 饰）由前集中的特工“菜鸟”升级为特工老手，他与梅林（马克·斯特朗 饰）将前往美国，与王牌特工组织的美国政治家（哈莉·贝瑞 饰）一起并肩作战。而他们所面对的敌人则是美艳狠毒的大反派波比（朱丽安·摩尔 饰）。</p>
				<a href="movie.aspx">浏 览 更 多....</a>
			</div>
			<ul>
				<li>
					<h3>雷神3：诸神黄昏</h3>
					<span>Thor: Ragnarök</span> <a href="movie.aspx"><img src="image/Film/666.png" alt=""></a>
				</li>
				<li>
					<h3>羞羞的铁拳</h3>
					<span>Never Say Die</span> <a href="movie.aspx"><img src="image/Film/铁拳.jpg" alt=""></a>
				</li>
				<li>
					<h3>全球风暴</h3>
					<span>Geostorm</span> <a href="movie.aspx"><img src="image/Film/风暴.jpg" alt=""></a>
				</li>
			</ul>
		</div>
		<div>
			
			<div >
				<a href="movie.aspx" style="color:deeppink" ><h3>即 将 上 映</a></h3>
				<ul style="text-align:center">
					<li >
						<a href="movie.aspx"><img src="image/Film/烟花.jpg" alt=""></a>
						<h4 > 烟 花（打ち上げ花火、下から見るか） </h4>
						<p>
							暑假里，某个海滨城镇。烟火大会前夕，几名中学生热烈地讨论着“升空的烟花从侧面看是圆的？还是扁的？”...
						</p>
					</li>
					<li>
						<a href="movie.aspx"><img src="image/film/狂兽.jpg" alt=""></a>
						<h4>狂 兽 (The Brink)</h4>
						<p>重案督察西狗（张晋 饰）与搭档阿德（吴樾 饰）追捕涉嫌多桩凶案的歹徒江贵成，意外发现大量被虐杀的尸体和的黑市黄金....
						</p>
					</li>
				</ul>
			</div >
			<div class="home2">
				<a href="index.aspx"><img src="image/Film/正义.jpg" alt=""></a>
				<h2 style="text-align:center"><a href="movies.html">正 义 联 盟（Justice League）</a></h2>
				<p>
					本片讲述了艾格西（塔伦·埃格顿 饰）由前集中的特工“菜鸟”升级为特工老手，他与梅林（马克·斯特朗 饰）将前往美国，与王牌特工组织的美国政治家（哈莉·贝瑞 饰）一起并肩作战。而他们所面对的敌人则是美艳狠毒的大反派波比（朱丽安·摩尔 饰）。

				</p>
			</div>

</div>
    </div>
</asp:Content>
