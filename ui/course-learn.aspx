<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="course-learn.aspx.cs" Inherits="Icthmw.ui.course_learn" %>
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
						<li class="kecheng" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="javascrtpt:void(0);" style="color:#50a3a2;">课程学习</a>
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
    <div class="learn-mianban">
		 	<div class="learn-mianban-daohang">当前位置：<a href="javascrtpt:void(0);" style="color:white">必修1 数据与计算</a>>认识数据与大数据</div>
		 	<div class="learn-title"><strong>认识数据与大数据</strong></div>
		 	<div class="learn-info">
		 		<div class="learn-people">点击数：306人次</div>
		 		<div class="learn-nandu">难度：一般</div>
		 		
		 	</div>
		 </div>
		<!--课程主要内容面板-->
		<div class="learn-main">
			<div class="learn-main-zhuti">
				<!--简介-->
				<div class="learn-main-info">
                    <p>主讲教师：暂无介绍</p>
					<p>本节简介：如今信息时代的人们生活在数据世界里，离不开数据，本节课让我一起来了解什么是数据。</p>					
				</div>
				<!--课程内容-->
				<div class="learn-ztreelist">
					<iframe style="position:static;margin:20px 150px 20px 0;width:105%;height:100%;z-index: auto;overflow:hidden" frameborder="0" scrolling="no" src="../courses/zt2019g01/z01/认识数据与大数据(配音版).html" webkitAllowFullScreen mozallowfullscreen allowFullScreen></iframe>
				</div>
                <div style="text-align:center;margin-top:40px;">
                    <button type="button" class="btn btn-info" onclick="javascrtpt:void(0);alert('没有更多内容了');">上一个视频</button>&emsp;
					<button type="button" class="btn btn-info" onclick="javascrtpt:void(0);alert('没有更多内容了');">下一个视频</button>
                </div>
                <hr />
                <div style="margin-left:150px;font-size:18px">
                    <span>相关资源：</span>
                    <ul>
                        <li style="padding-left:40px;padding-top:5px">老师还没有上传课件资料~</li>
                    </ul>
                </div>
			</div>
            </div>
</asp:Content>
