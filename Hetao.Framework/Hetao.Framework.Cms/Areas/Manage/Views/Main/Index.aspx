<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>仪表盘</title>
    <%: Styles.Render("~/theme/metronic") %>
    <%: Scripts.Render("~/bundles/modernizr") %>
    <link rel="shortcut icon" href="favicon.ico" />
    <style type="text/css">
        .iframe{
            border:0px;
            margin-left:-20px;
            margin-right:-20px;
            padding-left:20px;
            padding-right:20px;

        }
    </style>
</head>
<body class="fixed-top">
    <!-- BEGIN HEADER -->
    <div class="header navbar navbar-inverse navbar-fixed-top">
        <!-- BEGIN TOP NAVIGATION BAR -->
        <div class="navbar-inner">
            <div class="container-fluid">
                <!-- BEGIN LOGO -->
                <a class="brand" href="index.html">
                    <img src="/assets/img/logo.png" alt="logo" />
                </a>
                <!-- END LOGO -->
                <!-- BEGIN RESPONSIVE MENU TOGGLER -->
                <a href="javascript:;" class="btn-navbar collapsed" data-toggle="collapse" data-target=".nav-collapse">
                    <img src="/assets/img/menu-toggler.png" alt="" />
                </a>
                <!-- END RESPONSIVE MENU TOGGLER -->
                <!-- BEGIN TOP NAVIGATION MENU -->
                <ul class="nav pull-right">
                    <!-- BEGIN NOTIFICATION DROPDOWN -->
                    <li class="dropdown" id="header_notification_bar">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="icon-warning-sign"></i>
                            <span class="badge">6</span>
                        </a>
                        <ul class="dropdown-menu extended notification">
                            <li>
                                <p>You have 14 new notifications</p>
                            </li>
                            <li>
                                <a href="javascript:;" onclick="App.onNotificationClick(1)">
                                    <span class="label label-success"><i class="icon-plus"></i></span>
                                    New user registered. 
								<span class="time">Just now</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-important"><i class="icon-bolt"></i></span>
                                    Server #12 overloaded. 
								<span class="time">15 mins</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-warning"><i class="icon-bell"></i></span>
                                    Server #2 not respoding.
								<span class="time">22 mins</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-info"><i class="icon-bullhorn"></i></span>
                                    Application error.
								<span class="time">40 mins</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-important"><i class="icon-bolt"></i></span>
                                    Database overloaded 68%. 
								<span class="time">2 hrs</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-important"><i class="icon-bolt"></i></span>
                                    2 user IP blocked.
								<span class="time">5 hrs</span>
                                </a>
                            </li>
                            <li class="external">
                                <a href="#">See all notifications <i class="m-icon-swapright"></i></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END NOTIFICATION DROPDOWN -->
                    <!-- BEGIN INBOX DROPDOWN -->
                    <li class="dropdown" id="header_inbox_bar">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="icon-envelope-alt"></i>
                            <span class="badge">5</span>
                        </a>
                        <ul class="dropdown-menu extended inbox">
                            <li>
                                <p>You have 12 new messages</p>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="photo">
                                        <img src="/assets/img/avatar2.jpg" alt="" /></span>
                                    <span class="subject">
                                        <span class="from">Lisa Wong</span>
                                        <span class="time">Just Now</span>
                                    </span>
                                    <span class="message">Vivamus sed auctor nibh congue nibh. auctor nibh
								auctor nibh...
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="photo">
                                        <img src="/assets/img/avatar3.jpg" alt="" /></span>
                                    <span class="subject">
                                        <span class="from">Richard Doe</span>
                                        <span class="time">16 mins</span>
                                    </span>
                                    <span class="message">Vivamus sed congue nibh auctor nibh congue nibh. auctor nibh
								auctor nibh...
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="photo">
                                        <img src="/assets/img/avatar1.jpg" alt="" /></span>
                                    <span class="subject">
                                        <span class="from">Bob Nilson</span>
                                        <span class="time">2 hrs</span>
                                    </span>
                                    <span class="message">Vivamus sed nibh auctor nibh congue nibh. auctor nibh
								auctor nibh...
                                    </span>
                                </a>
                            </li>
                            <li class="external">
                                <a href="#">See all messages <i class="m-icon-swapright"></i></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END INBOX DROPDOWN -->
                    <!-- BEGIN TODO DROPDOWN -->
                    <li class="dropdown" id="header_task_bar">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="icon-tasks"></i>
                            <span class="badge">5</span>
                        </a>
                        <ul class="dropdown-menu extended tasks">
                            <li>
                                <p>You have 12 pending tasks</p>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">New release v1.2</span>
                                        <span class="percent">30%</span>
                                    </span>
                                    <span class="progress progress-success ">
                                        <span style="width: 30%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">Application deployment</span>
                                        <span class="percent">65%</span>
                                    </span>
                                    <span class="progress progress-danger progress-striped active">
                                        <span style="width: 65%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">Mobile app release</span>
                                        <span class="percent">98%</span>
                                    </span>
                                    <span class="progress progress-success">
                                        <span style="width: 98%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">Database migration</span>
                                        <span class="percent">10%</span>
                                    </span>
                                    <span class="progress progress-warning progress-striped">
                                        <span style="width: 10%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">Web server upgrade</span>
                                        <span class="percent">58%</span>
                                    </span>
                                    <span class="progress progress-info">
                                        <span style="width: 58%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">Mobile development</span>
                                        <span class="percent">85%</span>
                                    </span>
                                    <span class="progress progress-success">
                                        <span style="width: 85%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li class="external">
                                <a href="#">See all tasks <i class="m-icon-swapright"></i></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END TODO DROPDOWN -->
                    <!-- BEGIN USER LOGIN DROPDOWN -->
                    <li class="dropdown user">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <img alt="" src="/assets/img/avatar1_small.jpg" />
                            <span class="username">Bob Nilson</span>
                            <i class="icon-angle-down"></i>
                        </a>
                        <ul class="dropdown-menu">
                            <li><a href="extra_profile.html"><i class="icon-user"></i>My Profile</a></li>
                            <li><a href="calendar.html"><i class="icon-calendar"></i>My Calendar</a></li>
                            <li><a href="#"><i class="icon-tasks"></i>My Tasks</a></li>
                            <li class="divider"></li>
                            <li><a href="login.html"><i class="icon-key"></i>Log Out</a></li>
                        </ul>
                    </li>
                    <!-- END USER LOGIN DROPDOWN -->
                </ul>
                <!-- END TOP NAVIGATION MENU -->
            </div>
        </div>
        <!-- END TOP NAVIGATION BAR -->
    </div>
    <!-- END HEADER -->

    <!-- BEGIN CONTAINER -->
    <div class="page-container row-fluid">
        <!-- BEGIN SIDEBAR -->
        <div class="page-sidebar nav-collapse  collapse">
            <!-- BEGIN SIDEBAR MENU -->
            <ul>
                <li>
                    <!-- BEGIN SIDEBAR TOGGLER BUTTON -->
                    <div class="sidebar-toggler hidden-phone"></div>
                    <!-- BEGIN SIDEBAR TOGGLER BUTTON -->
                </li>
                <li>
                    <!-- BEGIN RESPONSIVE QUICK SEARCH FORM -->
                    <form class="sidebar-search">
                        <div class="input-box">
                            <a href="javascript:;" class="remove"></a>
                            <input type="text" placeholder="Search..." />
                            <input type="button" class="submit" value=" " />
                        </div>
                    </form>
                    <!-- END RESPONSIVE QUICK SEARCH FORM -->
                </li>
                <li class="start active ">
                    <a href="index.html">
                        <i class="icon-home"></i>
                        <span class="title">仪表盘</span>
                        <span class="selected"></span>
                    </a>
                </li>
                <li class="has-sub ">
                    <a href="javascript:;">
                        <i class="icon-bookmark-empty"></i>
                        <span class="title">文章管理</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub">
                        <li><a href="<%:Url.Action("Index","Article") %>" target="main">文章列表</a></li>
                        <li><a href="<%:Url.Action("Create","Article") %>" target="main">添加文章</a></li>
                       
                    </ul>
                </li>
                <li class="has-sub ">
                    <a href="javascript:;">
                        <i class="icon-table"></i>
                        <span class="title">类别管理</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub">
                         <li><a href="<%:Url.Action("Index","Category") %>" target="main">类别列表</a></li>
                         <li><a href="<%:Url.Action("Create","Category") %>" target="main">添加分类</a></li>
                    </ul>
                </li>
                <li class="has-sub ">
                    <a href="javascript:;">
                        <i class="icon-th-list"></i>
                        <span class="title">代理商</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub">
                        <li><a href="table_basic.html">Basic Tables</a></li>
                        <li><a href="table_managed.html">Managed Tables</a></li>
                        <li><a href="table_editable.html">Editable Tables</a></li>
                    </ul>
                </li>
                <li class="has-sub ">
                    <a href="javascript:;">
                        <i class="icon-th-list"></i>
                        <span class="title">系统</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub">
                        <li><a href="<%:Url.Action("index","admin") %>" target="main">管理员账户</a></li>
                        <li><a href="portlet_draggable.html">员工账户</a></li>
                    </ul>
                </li>

                <li class="">
                    <a href="<%:Url.Action("logout") %>">
                        <i class="icon-user"></i>
                        <span class="title">退出系统</span>
                    </a>
                </li>
            </ul>
            <!-- END SIDEBAR MENU -->
        </div>
        <!-- END SIDEBAR -->
        <!-- BEGIN PAGE -->
        <div class="page-content">
            <!-- BEGIN SAMPLE PORTLET CONFIGURATION MODAL FORM-->
            <div id="portlet-config" class="modal hide">
                <div class="modal-header">
                    <button data-dismiss="modal" class="close" type="button"></button>
                    <h3>Widget Settings</h3>
                </div>
                <div class="modal-body">
                    <p>Here will be a configuration form</p>
                </div>
            </div>
            <!-- END SAMPLE PORTLET CONFIGURATION MODAL FORM-->
            <!-- BEGIN PAGE CONTAINER-->
            <div class="container-fluid">

                <iframe src="<%:Url.Action("center","main") %>" width="100%" name="main" id="main" frameboder="0" class="iframe" ></iframe>
            </div>
            <!-- END PAGE CONTAINER-->
        </div>
        <!-- END PAGE -->
    </div>
    <!-- END CONTAINER -->

    <!-- BEGIN FOOTER -->
    <div class="footer">
        2015 &copy; wxllzf
		
        <div class="span pull-right">
            <span class="go-top"><i class="icon-angle-up"></i></span>
        </div>
    </div>
    <!-- END FOOTER -->
    <%: Scripts.Render("~/js/metronic") %>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#main").load(function () {
                $(this).height(0); //用于每次刷新时控制IFRAME高度初始化 
                var height = $(this).contents().height() ;
                $(this).height(height < 500 ? 500 : height);
            });

            $(window.frames["main"]).resize(function () {
                
                $("#main").height(0); //用于每次刷新时控制IFRAME高度初始化 
                var height = $("#main").contents().height();
                $("#main").height(height < 500 ? 500 : height);
            });
        });
    </script>
    <script type="text/javascript">
        jQuery(document).ready(function () {
            App.setPage("index");  // set current page
            App.init(); // init the rest of plugins and elements
        });
    </script>
</body>
</html>
