<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="askortalk-read.aspx.cs" Inherits="Icthmw.ui.askortalk_read" %>
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
		<div class="talk-body-read">
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
			<div class="talk-mainban-read">
				<div class="talk-mainban-header">
					当前位置：课堂讨论>谈谈你对“大数据”概念的理解？
				</div>
				<div class="talk-mainban-body-read">
					<div class="talk-ask">
						<div class="talk-ask-question">
							<img src="/img/question.png" />
							<h3>谈谈你对“大数据”概念的理解？</h3>
						</div>
						<div class="talk-ask-content">
							随着大数据的概念提出，越来越多的人，开始关注数据，注重数据带来的巨大的价值。那么学习了这节课程，你认为大数据是什么？大数据能带来那些价值呢？
						
						</div>
						
						<div class="talk-ask-question-info">						
						<div>提问人：苏老师 &emsp;| 2020-4-27 00:48:56 &emsp;| 浏览数 1次&emsp; | 回复数：1次</div>	
						</div>
					</div>
					<div class="talk-t"><h3 style="color: #10AE58;">评论回复</h3></div>
					
					<div class="talk-answerAN">
						<div class="answerAN-tit"><img src="/img/answer.png"/><h3 style="color: #10AE58;">置顶内容</h3></div>
						<div class="talk-answer-content">
							<p>
								请同学们认真参与课堂讨论。
							</p>
						</div>
						<div class="talk-answer-info">
							<div>苏老师  |2020-4-27 00:53:32 <div class="cilked"> <button class="btn btn-success">已置顶内容</button></div></div>
							
						</div>
						
					</div>	
                    </div>
                <hr />
                 <div class="talk-answer-content">
                     <textarea style="margin-left:50px;height:100px;width:85%"></textarea>&emsp;
                     <input type="submit" style="background-color:#10AE58;color:white;border:none;width:80px;height:30px" value="回 复" />
                </div>
				</div>
			</div>
</asp:Content>
