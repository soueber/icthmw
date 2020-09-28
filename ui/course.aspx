<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="course.aspx.cs" Inherits="Icthmw.ui.course" %>
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
							<a href="#" style="color:#50a3a2;">课程学习</a>
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
    <div class="course-body">
			<div class="course-datu">
				
				<img src="/img/banner_new.jpg" />
			</div>
			
		 <div class="course-body-main">
		 	<div class="course-body-daohang">
		 		<nav>
		 			<ul>
		 				<li> <a href="#">最新</a></li>
		 				<li><a href="#">最热</a></li>
		 			</ul>
		 			
		 		</nav>
		 		
		 	</div>
		 	<!--课程模块-->
             <asp:LinkButton CssClass="course-modal" runat="server" OnClick="Unnamed_Click">
		 	
		 		<div class="course-modal-header">认识数据与大数据</div>
		 		<div class="course-modal-body">如今信息时代的人们生活在数据世界里，离不开数据，本节课让我一起来了解什么是数据。</div>
		 		<div class="course-modal-foot"><center>1人在学</center></div>
		 	
		 </asp:LinkButton>
		
		 </div>	
			<div class="course-body-footer">
		 		<center>
        		<ul class="pagination">
                  <li><a href="#">&laquo;</a></li>
                  <li><a href="#">1</a></li>
                  <li><a href="#">2</a></li>
                  <li><a href="#">3</a></li>
                   <li><a href="#">4</a></li>
                  
                   <li><a href="#">&raquo;</a></li>
                 </ul>
                 </center>
		 	</div>
        </div>
</asp:Content>
