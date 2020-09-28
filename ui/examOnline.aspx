<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="examOnline.aspx.cs" Inherits="Icthmw.ui.examOnline" %>
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
						<li class="kecheng" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="javascrtpt:void(0);" style="color:#50a3a2;">模拟测试</a>
						</li>
						<li class="moretitle" >
							<a href="askortalk.aspx" >学习讨论</a>
						</li>
					</ul>

				</nav>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="exam-datu">
			
			<img src="/img/course-banner.jpg" />
		</div>
		<!--主体-->
		<div class="exam-main">
			<div class="exam-daohang-title">
				<div class="exam-title">课程题库</div>
				<div class="exam-title-eng">COURSE</div>
			</div>
			<!--题库面板-->
			<div class="exam-mianban">
				
                    <asp:LinkButton CssClass="exam-course" runat="server" OnClick="Unnamed_Click">
					<div class="exam-course-title">认识数据与大数据(基础)</div>
					<div class="exam-course-body">本练习是认识数据与大数据基础训练题，每位同学均需完成</div>
                        </asp:LinkButton>
                <asp:LinkButton CssClass="exam-course" runat="server" OnClick="Unnamed_Click1">
					<div class="exam-course-title">认识数据与大数据(提升)</div>
					<div class="exam-course-body">本练习是认识数据与大数据拓展训练题，可根据需要完成，会有额外加分哦~</div>
				</asp:LinkButton>
			
			</div>
			<!--分页-->
			<div class="exam-fenye">
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
</asp:Content>
