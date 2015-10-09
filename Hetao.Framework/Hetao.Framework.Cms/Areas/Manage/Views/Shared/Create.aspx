<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<Hetao.Framework.Contract.ModelBase>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row-fluid">
        <div class="span12">

            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
            <h3 class="page-title">添加				
						
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

            <div class="form-horizontal">
                <% using (Html.BeginForm())
                   { %>
                <%: Html.AntiForgeryToken() %>
                <%: Html.ValidationSummary(true) %>

                <fieldset>
                    
                    <%:Html.EditModel() %>
                    <div class="form-actions">
                        <button type="submit" class="btn blue"><i class="icon-ok"></i>保存</button>
                        <%: Html.ActionLink("回到列表", "Index", null, new { @class="btn" })%>
                    </div>
                </fieldset>
                <% } %>
            </div>
        </div>
    </div>


</asp:Content>
