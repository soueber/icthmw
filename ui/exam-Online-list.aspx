<%@ Page Title="" Language="C#" MasterPageFile="~/mu/banner.Master" AutoEventWireup="true" CodeBehind="exam-Online-list.aspx.cs" Inherits="Icthmw.ui.exam_Online_list" %>
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
    <div style="height:100%">
    <div class="exam-datu-list">
			
			<img src="/img/major-banner.jpg" />
		</div>
		<!--主体-->
		<div class="exam-main-list">
			<div class="exam-main-list-body">
				<div class="exam-main-list-body-header">
					<div class="exam-tiku-name">数据与计算--课程题库</div>
					<div class="exam-tiku-zice"><button type="button" class="btn btn-success btn-lg btn-block" onclick="javascrtpt:void(0);alert('教师未开放此部分功能');">随机自测</button></div>
				</div>
				
				<div class="exam-tiku-list">
                    <div class="exam-list-ul">
                        <p>1.利簋是西周早期青铜器，1976年土于陕西省临潼县零口镇。器内底铸铭文4行，共33字，记载了甲子日清晨武王伐纣这一重大历史事件。信息记载于簋上体现的信息基本特征是( )。</p>
                        <div style="padding-left:5px"><asp:RadioButtonList runat="server" ID="q_1" Font-Size="16px" ForeColor="#252525">
                            <asp:ListItem>A.载体依附性</asp:ListItem>
                            <asp:ListItem>B.价值性</asp:ListItem>
                            <asp:ListItem>C.时效性</asp:ListItem>
                            <asp:ListItem>D.共享性</asp:ListItem>
                        </asp:RadioButtonList>
                        </div>
                        <div runat="server" id="q_1_c"></div>
                         <p>2.国外某商场的收款系统显示，感恩节前后啤酒与尿布的销售量要比平日多。经分析，原来是好多家庭主妇在这几天出去逛街，留下男人在家里看孩子。男人一边照看孩子，一边又要喝啤酒看球赛，致使啤酒与尿布的需求量大增。于是这家商场干脆把啤酒与尿布摆到一起，让顾客顺手就能拿到，大大促进了销售。啤酒与尿布的故事体现了信息的什么特征? ( )</p>
                        <div style="padding-left:5px"><asp:RadioButtonList runat="server" ID="q_2" Font-Size="16px" ForeColor="#252525">
                            <asp:ListItem>A.载体依附性</asp:ListItem>
                            <asp:ListItem>B.价值性</asp:ListItem>
                            <asp:ListItem>C.时效性</asp:ListItem>
                            <asp:ListItem>D.共享性</asp:ListItem>
                        </asp:RadioButtonList>
                        </div>
                        <div runat="server" id="q_2_c"></div>
                    </div>
                    <div style="text-align:center;padding-top:10px;">
                     <button type="button" class="btn btn-info" runat="server" id="simbit_q">提交答案</button>&emsp;
                    </div>
				</div>
				
			</div>
            </div>
        </div>
</asp:Content>
