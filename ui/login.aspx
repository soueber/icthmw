<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Icthmw.ui.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="/js/getcode.js"></script>
        <script type="text/javascript">
            $(document).ready(function () {
                $("form").submit(function () {
                    var Name = $("input[name=user]").val();
                    var Pwd = $("input[name=pass]").val();
                    var Cod = $("input[name=code]").val();
                    var num = show_num.join("");
                    if ((Name === "") || (Pwd === "") || (Cod === "")) {
                        alert("请输入全部信息");
                        return false;
                    }
                    else {
                        if (Cod == num) {
                            return true;
                        }
                        else {
                            alert("验证码错误");
                            draw(show_num);
                            return false;
                        }
                    }
                });
            });
        </script>
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
    <div class="login-container">
		 	<div class="login-body">
		 	<div class="login-form">
		 		<div class="login-form-xianshi">
		 			<div class="login-form-header">用户登录</div>
                    <div class="login-con">
                        <label class="login-us">账号：</label>
                        <input type="text" class="login-username" placeholder="请输入登录邮箱" name="user" id="email" runat="server" />
                        <label class="login-ps">密码：</label>
                        <input type="password" class="login-password" placeholder="请输入您的密码" name="pass" id="pwd" runat="server"  />
                        <label class="login-code">验证码：</label>
                        <input name="code" type="text" class="login-codenum" placeholder="请输入验证码" />&emsp;<canvas id="canvas" style="vertical-align:middle;" onclick="dj()" class="login_codeimg"></canvas>
                        <input name="button" class="login-denglu-btn" type="submit" value="登 录" runat="server" id="btn"/>
                    </div>
		 			  
		 		</div>
		 		
		 	</div>
		 	</div>
		 </div>
</asp:Content>
