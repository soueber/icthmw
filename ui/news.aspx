<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="Icthmw.ui.news" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_daohang" runat="server">
    <nav class="daohang">
					<ul>
						<li class="shouye" >
							<a href="index.aspx">首页</a>
						</li>
						<li class="ziyuan">
							<a href="resource.aspx" >资源</a>
						</li>
						<li class="jiaoxuetuand">
							<a href="tool.aspx" >开发工具</a>
						</li>
						<li class="news" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="#" style="color:#50a3a2;">最新资讯</a>
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
    <div class="new-body">
			<!--大图-->
			<div class="new-datu">
				<img src="/img/banner_wh_news.jpg" />
			</div>
			
			<div class="new-daohang">
				<div class="new-mianbandaohang">
			<a href="index.aspx">首页</a> 》<a href="#">课程推荐</a>
			</div>
			</div>
			<!--主体显示部分-->
			<div class="new-xianshi">
				<div class="new-sibar">
					<div class="new-sibar-header">
						<p>推荐学习</p>
					</div>
				<div class="new-sibar-body">
				 <ul>
				 	<li><a href="new-read.aspx"><img src="/img/new-titlequan.jpg" />数据与计算</a></li>
				 	<li><a href="#"><img src="/img/new-titlequan.jpg" />人工智能</a></li>
				 	<li><a href="#"><img src="/img/new-titlequan.jpg" />大数据在生活中的应用</a></li>
				 	<li><a href="#"><img src="/img/new-titlequan.jpg" />数据的处理过程</a></li>
				 	<li><a href="#"><img src="/img/new-titlequan.jpg" />教你如何在1个月内玩转PPT</a></li>
				 </ul>	
				</div>	
					
				</div>
				<div class="new-xianshi-right">
					<div class="new-xianshi-right-header">
						<span>资源推荐</span>
						
					</div>
					<div class="new-xianshi-right-center">
						<ul>
							<li><a href="new-read.aspx"><img src="/img/new-titlequan.jpg" />上线了<div class="new-title-button">2020-4-27 </div></a></li>
						</ul>
						
					</div>
					<div class="new-xianshi-right-foot">
						<center>
        		<ul class="pagination">
                  <li><a href="#">&laquo;</a></li>
                  <li><a href="#">1</a></li>
                  <li><a href="#">2</a></li>
                  <li><a href="#">3</a></li>
                   <li><a href="#">4</a></li>
                  <li><a href="#">5</a></li>
                   <li><a href="#">&raquo;</a></li>
                 </ul>
                 </center>
					</div>
					
				</div>
				
				
			</div>
</asp:Content>
