<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="askortalk.aspx.cs" Inherits="Icthmw.ui.askortalk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_daohang" runat="server">
    <nav class="daohang">
					<ul>
						<li class="shouye" >
							<a href="index.aspx">首页</a>
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
						<li class="kecheng" >
							<a href="course.aspx" >课程学习</a>
						</li>
						<li class="kecheng">
							<a href="examOnline.aspx">模拟测试</a>
						</li>
						<li class="moretitle" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="javascrtpt:void(0);" style="color:#50a3a2;">学习讨论</a>
						</li>
					</ul>

				</nav>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="talk-datu">
			
			<img src="/img/banner-talk.jpg" />
		</div>
		<!--主体-->
		<div class="talk-body">
			<!--导航-->
			<nav class="talk-daohang">
        		<div class="talk-daohang-title">
        		<div class="talk-allres"><a href="javascrtpt:void(0)">全部</a></div>
        		<div class="talk-zuire"><a href="javascrtpt:void(0)">课堂讨论</a></div>
        		<div class="talk-news"><a href="javascrtpt:void(0)">答疑反馈</a></div>
        		<div class="talk-finish"><a href="javascrtpt:void(0)">小组讨论区</a></div>
        		<div class="talk-unfinish"><a href="javascrtpt:void(0)">综合讨论区</a></div>
        		
        		</div>
        	</nav>
			<!--主体内容-->
			<div class="talk-mainban">
				<div class="talk-mainban-header">
					当前位置：课堂讨论
				</div>
				<div class="talk-mainban-body">
					<ul>
						<li><a  class="talk-title" href="askortalk-read.aspx">谈谈你对“大数据”概念的理解？</a>
							<div class="talk-xinx">
							<span class="talk-user">苏老师</span>
							<span class="talk-zhuangtai">进行中</span>
							<span class="talk-time">提出时间：2020-4-27</span>
							</div>
						</li>
						<li><a  class="talk-title" href="askortalk-read.aspx">我们生活中存在大数据吗？大数据在生活中体现在哪些方面？</a>
							<div class="talk-xinx">
							<span class="talk-user">苏老师</span>
							<span class="talk-zhuangtai">进行中</span>
							<span class="talk-time">提出时间：2020-4-27</span>
							</div>
						</li>
						<li><a  class="talk-title" href="askortalk-read.aspx">谈谈你如何理解数据、信息和知识三者的关系？</a>
							<div class="talk-xinx">
							<span class="talk-user">苏老师</span>
							<span class="talk-zhuangtai">进行中</span>
							<span class="talk-time">提出时间：2020-4-27</span>
							</div>
						</li>
					</ul>
					
					
				</div>
				<div class="talk-mainban-fenye">
						<center>
        		<ul class="pagination">
                  <li><a href="javascrtpt:void(0);">&laquo;</a></li>
                  <li><a href="javascrtpt:void(0);">1</a></li>
                  <li><a href="javascrtpt:void(0);">2</a></li>
                  <li><a href="javascrtpt:void(0);">3</a></li>
                  
                   <li><a href="javascrtpt:void(0);">&raquo;</a></li>
                 </ul>
                 </center>
					</div>
			</div>
</asp:Content>
