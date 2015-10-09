<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Hetao.Framework.Cms.Services.Models.Article>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row-fluid">
        <div class="span12">

            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
            <h3 class="page-title">文章管理				
						
                            <small>Articles</small>
            </h3>
            <ul class="breadcrumb">
                <li>
                    <i class="icon-home"></i>
                    <a href="#">文章管理</a>
                    <i class="icon-angle-right"></i>
                </li>
                <li><a href="#">文章列表</a></li>

            </ul>
            <!-- END PAGE TITLE & BREADCRUMB-->
        </div>
    </div>
    <!-- 列表-->
    <div class="row-fluid">
        <div class="span12">

            <%:Html.EasyUIGrid(Model) %>
        </div>
    </div>


</asp:Content>
