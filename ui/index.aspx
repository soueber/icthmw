<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Icthmw.ui.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_daohang" runat="server">
    <nav class="daohang">
					<ul>
						<li class="shouye" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="index.aspx" style="color:#50a3a2;">首页</a>
						</li>
						<li class="ziyuan">
							<a href="resource.aspx">资源</a>
						</li>
						<li class="jiaoxuetuand">
							<a href="tool.aspx">开发工具</a>
						</li>
						<li class="news">
							<a href="news.aspx">最新资讯</a>
						</li>
						<li class="kecheng">
							<a href="course.aspx">课程学习</a>
						</li>
						<li class="kecheng">
							<a href="examOnline.aspx">模拟测试</a>
						</li>
						<li class="moretitle">
							<a href="askortalk.aspx">学习讨论</a>
						</li>
					</ul>

				</nav>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-contion">
			<!--轮播-->
			<div class="lunbo">
				<section class="slider-contaner">
					<ul class="slider">
						<li class="slider-item slider-item1"></li>
						<li class="slider-item slider-item2"></li>
						<li class="slider-item slider-item3"></li>
						<li class="slider-item slider-item4"></li>
						<li class="slider-item slider-item5"></li>
					</ul>
					<div class="focus-container">
						<ul class="floatfix">
							<li>
								<div class="focus-item focus-item1"></div>
							</li>
							<li>
								<div class="focus-item focus-item2"></div>
							</li>
							<li>
								<div class="focus-item focus-item3"></div>
							</li>
							<li>
								<div class="focus-item focus-item4"></div>
							</li>
							<li>
								<div class="focus-item focus-item5"></div>
							</li>
						</ul>
					</div>
				</section>

			</div>
			
			<!--中间分区-->
			<div  class="centermodal">
				<div class="zuixinzixun">
					<div class="zixin-head">最新资讯
					<div class="zixin-more"><a href="news.aspx" title="查看更多资讯">···</a></div>
					</div>
					<div class="zixin-body">
						<img src="/img/newsimg.png">
						<ul>
							<li><a href="javascrtpt:void(0)" style="color:#444444">《数据与计算》课程上线了.....</a></li>
                            <li><a href="javascrtpt:void(0)" style="color:#444444">《信息系统与社会》课程上线了.....</a></li>
							
						</ul>
					</div>
				</div>
				<div class="ziyuanxiazai">
					<div class="xiazai-head">资源下载
					<div class="xiazai-more"><a href="resource.aspx" title="查看更多资源">···</a></div>
					</div>
					<div class="xiaz-body">
							<img src="/img/newsimg.png">
                            <ul>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">程序设计基本知识</a></li>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">数据处理的一般过程</a></li>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">数据分析报告与应用</a></li>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">利用智能工具解决问题</a></li>
                            </ul>
					</div>
				</div>
				<div class="kechenghudong">

					<div class="huodong-head">课程学习
					<div class="huodong-more"><a href="course.aspx" title="查看更多课程">···</a></div>
					</div>
					<div class="huodong-body">
							<img src="/img/newsimg.png">
                            <ul>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">主题项目学习：体质数据促健康</a></li>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">数据科学与大数据</a></li>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">解决问题的一般过程和用计算机解决问题</a></li>
                                <li><a href="javascrtpt:void(0)" style="color:#444444">常见算法的程序实现</a></li>

                            </ul>
					</div>
				</div>
			 
			</div>
				 <!--中间标语-->
			 <div class="center-biaoyu">
			 	
                 <a href="/blockly/demos/index.aspx" target="_blank"><img src="/img/tiaoyu.png" /></a>
			 </div>
			<div class="lastbody">
			<!--专题资源-->
			 <div class="zhuanti-ziyuan">
			 	<div class="zhuanti-head">最新资讯
					<div class="zhuanti-more"><a href="#">···</a></div>
					</div>
                <div class="zhuanti-body">
                    <div style="display:inline-block">
                        <ul style="list-style:none;margin:0px; ">
                            <li style="float:left;"><a href="javascrtpt:void(0)"><img src="/img/zhuanti.jpg" style="width:500px"/></a>&emsp;</li>
                            <li style="float:left; "><a href="javascrtpt:void(0)"><img src="/img/zhuanti_2.jpg" style="width:auto" /></a></li>
                        </ul> 
                    </div>
                </div>
			 </div>
			</div> 		
		</div>
</asp:Content>
