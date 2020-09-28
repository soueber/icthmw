<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="new-read.aspx.cs" Inherits="Icthmw.ui.new_read" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_daohang" runat="server">
    <nav class="daohang">
					<ul>
						<li class="shouye">
							<a href="index.aspx">首页</a>
						</li>
						<li class="ziyuan">
							<a href="resource.aspx">资源</a>
						</li>
						<li class="jiaoxuetuand">
							<a href="tool.aspx">开发工具</a>
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
    <div class="new-read-body">
			<div class="new-read-center">
				<div class="new-read-sibar">
					<div class="new-read-sibar-headr">学习推荐</div>
					<div class="new-read-sibar-body">
						<ul>
							<li><a href="#"></a></li>
						</ul>
					</div>
					
					
				</div>
				<div class="new-read-right">
					<div class="new-read-right-header">
						<center>
							<p>上线了</p>
						</center>
					</div>
					<div class="new-read-right-small">
						<center>
							<span class="new-span">作者：admin</span>
							<span class="new-span">文章来源：测试</span>
							<span class="new-span">点击数：1</span>
							<span class="new-span">发布时间： 2020-4-27 00:58:50</span>
						</center>
					</div>
					<!--正文模块-->
					<div class="new-zhengwen">
						<p>
							上线了！
						</p>

					</div>

				</div>
			</div>
</asp:Content>
