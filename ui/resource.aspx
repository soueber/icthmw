<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="Resource.aspx.cs" Inherits="Icthmw.ui.Resource" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_daohang" runat="server">
    <nav class="daohang">
					<ul>
						<li>
							<a href="index.aspx">首页</a>
						</li>
						<li class="shouye" style="text-decoration:none;font-size: 19px;font-weight:bold;padding-bottom:7px;border-bottom:3px solid #50a3a2;">
							<a href="resource.aspx" style="color:#50a3a2;">资源</a>
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
    <div class="res-mainbody">
        	 <!--搜索栏部分-->
        	<nav class="res-sousuo">
        		<div class="sousuodaohang">
        		<div class="allres"><a href="#">全部</a></div>
        		<div class="kejianku"><a href="#">课件库</a></div>
        		<div class="shangjitiku"><a href="#">上机题库</a></div>
        		<div class="shitiku"><a href="#">试题库</a></div>
        		<div class="shipinku"><a href="#">视频库</a></div>
        		<div class="anliku"><a href="#">案例库</a></div>
        		 <div class="sousuobiaodan"><!--搜索表单-->
                   <div class="navbar-form navbar-left" role="search">
                      <div class="form-group">
                           <input type="text" class="form-control" placeholder="请输入关键字">
                      </div>
                     <button type="submit" class="btn btn-default">搜索</button>
                    </div>  <!--搜索表单结束-->  
                  </div>
        		</div>
        	</nav>
        	
       
        
        
        <!--显示部分-->
        <div class="res-xianshimain">
        	
        	 <!--侧边栏部分-->	
        <div class="res-sibar">
        	<div class="res-sibar-headr">
        		最新资源
        	</div>
        	<div class="res-sibar-body" >
        		<ul>
        			<li>
        			 <div class="news-first">
        			  <img src="/img/res-num1.jpg" />	
        			   <a><small><%# Eval("_filename_top1") %></small></a>
        			 </div>
        			</li>
        			
        			<li>
        			  <div class="new-order">
        			   <img src="/img/num2.png" />	
        			    <a><small><%# Eval("_filename_top2") %></small></a>
        			  </div>
        			</li>
        			
        			<li>
        			 <div class="new-order">
        			  <img src="/img/num3.png" />	
        			   <a><small><%# Eval("_filename_top3") %></small></a>
        			 </div>
        			</li>
        			<li>
        			 <div class="new-order">
        			  <img src="/img/num4.png" />	
        			   <a><small><%# Eval("_filename_top4") %></small></a>
        			 </div>
        			</li>
        			<li>
        			 <div class="new-order">
        			  <img src="/img/num5.png" />	
        			   <a><small><%# Eval("_filename_top5") %></small></a>
        			 </div>
        			</li>
        			<li>
        			 <div class="new-order">
        			  <img src="/img/num6.png" />	
        			   <a><small><%# Eval("_filename_top6") %></small></a>
        			 </div>
        			</li>
        		</ul>
        		
        	</div>
        	
        	
        </div>
        	
        <div class="res-center">
        	<div class="res-header">
        		<span>当前位置：资源  > 全部</span><div class="res-more">共搜索到 <%# Eval("_count") %>个</div>
        	</div>
        	<div class="res-body">
        		<!--每条资源-->	
        		<div class="res-body-title">
        			<div class="res-title-img">
        				<img src="/img/res.jpg" />
        			</div>
        			<div class="res-title"><a href="#"><%# Eval("_filename") %></a><br/><small><%# Eval("_admin") %></small>  <small>上传时间：<%# Eval("_time") %></small>    <small>大小：<%# Eval("_size") %></small></div>
        			<div class="res-title-download"><a href="#">点击下载</a></div>
        		</div>     	      		
        	</div>
        	<div class="res-body-yema">
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
        </div>
</asp:Content>
