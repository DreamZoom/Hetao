<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Center
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h3>欢迎使用CMS系统</h3>

    <%:Html.Action("Count","resource") %>

    <table class="table table-striped table-hover">
        <tbody>
            <tr>
                <td>当前登录名： </td>
                <td><%: Hetao.Framework.Web.Auth.AuthorProvider.Admin.getName() %></td>
            </tr>
            <tr>
                <td>服务器IP：   </td>
                <td><%=Request.ServerVariables["LOCAL_ADDR"]%>                       </td>
            </tr>
            <tr>
                <td>服务器名：   </td>
                <td><%=Request.ServerVariables["SERVER_NAME"]%>                        </td>
            </tr>
            <tr>
                <td>HTTP端口：   </td>
                <td><%=Request.ServerVariables["SERVER_PORT"]%>                        </td>
            </tr>
            <tr>
                <td>服务器时间： </td>
                <td><%=DateTime.Now%>                                                  </td>
            </tr>
            <tr>
                <td>操作系统信息</td>
                <td><%=Request.ServerVariables["HTTP_USER_AGENT"]%>                    </td>
            </tr>
            <tr>
                <td>允许文件：   </td>
                <td><%=Request.ServerVariables["HTTP_ACCEPT"]%>                        </td>
            </tr>
            <tr>
                <td>虚拟目录：   </td>
                <td><%=HttpContext.Current.Request.ApplicationPath%>                   </td>
            </tr>
            <tr>
                <td>物理路径：   </td>
                <td><%=HttpRuntime.AppDomainAppPath%>                                  </td>
            </tr>
            <tr>
                <td>探针文件路径：</td>
                <td><%=Context.Server.MapPath(Request.ServerVariables["SCRIPT_NAME"])%></td>
            </tr>
            <tr>
                <td>脚本超时时间：</td>
                <td><%=Server.ScriptTimeout%>（秒）                                    </td>
            </tr>
            <tr>
                <td>CPU个数:     </td>
                <td><%=Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS")%>    </td>
            </tr>

        </tbody>
    </table>
    <!-- BEGIN PAGE HEADER-->
    <%-- <div class="row-fluid">
        <div class="span12">

            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
            <h3 class="page-title">仪表盘				
						
                            <small>Dashboard</small>
            </h3>
            <ul class="breadcrumb">
                <li>
                    <i class="icon-home"></i>
                    <a href="index.html">首页</a>
                    <i class="icon-angle-right"></i>
                </li>
                <li><a href="#">仪表盘</a></li>

            </ul>
            <!-- END PAGE TITLE & BREADCRUMB-->
        </div>
    </div>
    <!-- END PAGE HEADER-->
    <div id="dashboard">
        <!-- BEGIN DASHBOARD STATS -->
        <div class="row-fluid">
            <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
                <div class="dashboard-stat blue">
                    <div class="visual">
                        <i class="icon-comments"></i>
                    </div>
                    <div class="details">
                        <div class="number">
                            1349
									
                        </div>
                        <div class="desc">
                            New Feedbacks
									
                        </div>
                    </div>
                    <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i>
                    </a>
                </div>
            </div>
            <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
                <div class="dashboard-stat green">
                    <div class="visual">
                        <i class="icon-shopping-cart"></i>
                    </div>
                    <div class="details">
                        <div class="number">549</div>
                        <div class="desc">New Orders</div>
                    </div>
                    <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i>
                    </a>
                </div>
            </div>
            <div class="span3 responsive" data-tablet="span6  fix-offset" data-desktop="span3">
                <div class="dashboard-stat purple">
                    <div class="visual">
                        <i class="icon-globe"></i>
                    </div>
                    <div class="details">
                        <div class="number">+89%</div>
                        <div class="desc">Brand Popularity</div>
                    </div>
                    <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i>
                    </a>
                </div>
            </div>
            <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
                <div class="dashboard-stat yellow">
                    <div class="visual">
                        <i class="icon-bar-chart"></i>
                    </div>
                    <div class="details">
                        <div class="number">12,5M$</div>
                        <div class="desc">Total Profit</div>
                    </div>
                    <a class="more" href="#">View more <i class="m-icon-swapright m-icon-white"></i>
                    </a>
                </div>
            </div>
        </div>
        <!-- END DASHBOARD STATS -->
        <div class="clearfix"></div>
        <div class="row-fluid">
            <div class="span6">
                <!-- BEGIN PORTLET-->
                <div class="portlet solid bordered light-grey">
                    <div class="portlet-title">
                        <h4><i class="icon-bar-chart"></i>Site Visits</h4>
                        <div class="tools">
                            <div class="btn-group pull-right" data-toggle="buttons-radio">
                                <a href="javascript:;" class="btn mini">Users</a>
                                <a href="javascript:;" class="btn mini active">Feedbacks</a>
                            </div>
                        </div>
                    </div>
                    <div class="portlet-body">
                        <div id="site_statistics_loading">
                            <img src="assets/img/loading.gif" alt="loading" />
                        </div>
                        <div id="site_statistics_content" class="hide">
                            <div id="site_statistics" class="chart"></div>
                        </div>
                    </div>
                </div>
                <!-- END PORTLET-->
            </div>
            <div class="span6">
                <!-- BEGIN PORTLET-->
                <div class="portlet solid light-grey bordered">
                    <div class="portlet-title">
                        <h4><i class="icon-bullhorn"></i>Activities</h4>
                        <div class="tools">
                            <div class="btn-group pull-right" data-toggle="buttons-radio">
                                <a href="javascript:;" class="btn blue mini active">Users</a>
                                <a href="javascript:;" class="btn blue mini">Orders</a>
                            </div>
                        </div>
                    </div>
                    <div class="portlet-body">
                        <div id="site_activities_loading">
                            <img src="assets/img/loading.gif" alt="loading" />
                        </div>
                        <div id="site_activities_content" class="hide">
                            <div id="site_activities" style="height: 100px;"></div>
                        </div>
                    </div>
                </div>
                <!-- END PORTLET-->
                <!-- BEGIN PORTLET-->
                <div class="portlet solid bordered light-grey">
                    <div class="portlet-title">
                        <h4><i class="icon-signal"></i>Server Load</h4>
                        <div class="tools">
                            <div class="btn-group pull-right" data-toggle="buttons-radio">
                                <a href="javascript:;" class="btn red mini active">
                                    <span class="hidden-phone">Database</span>
                                    <span class="visible-phone">DB</span></a>
                                <a href="javascript:;" class="btn red mini">Web</a>
                            </div>
                        </div>
                    </div>
                    <div class="portlet-body">
                        <div id="load_statistics_loading">
                            <img src="assets/img/loading.gif" alt="loading" />
                        </div>
                        <div id="load_statistics_content" class="hide">
                            <div id="load_statistics" style="height: 108px;"></div>
                        </div>
                    </div>
                </div>
                <!-- END PORTLET-->
            </div>
        </div>
        <div class="clearfix"></div>

    </div>--%>
</asp:Content>
