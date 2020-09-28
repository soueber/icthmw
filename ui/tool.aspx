<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="tool.aspx.cs" Inherits="Icthmw.ui.tool" %>
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
						<li class="jiaoxuetuand" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="#" style="color:#50a3a2;">开发工具</a>
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
     <div class="serch-main">
        
         <!--大图-->
        <div class="serch-datu">
        	<img src="/img/banner_tea1.jpg" />	
        </div>
         <!--中间模块-->
        <div class="serch-body">
        	<div class="serch-sidbar"><!--侧边栏-->
        		<div class="serch-sidbar-header">
        			<ul>
        			<li><center><a>开发环境</a></center></li>
        			
        			<li><center><a href="#">数据库配置</a></center></li>
        			
        			<li><center><a href="#">开发软件下载</a></center></li>
        			</ul>
        		</div>
        		<div class="serch-sidbar-more">
        			
        			<div class="serch-sibar-more-test">
        				<center><a href="examOnline.aspx">在线测试</a></center></div>
        				<div class="serch-sibar-more-ziyuan">
        					<center><a href="resource.aspx">资源下载</a></center></div>
        		</div>
        	</div>
        	<div class="serch-xianshi">
        		<div class="serch-xianshi-head">
        			<span>当前位置：开发工具</span>
        			
        		</div>
        		
        	</div>
        	
        </div>
</asp:Content>
