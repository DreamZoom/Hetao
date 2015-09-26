<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<Hetao.Framework.Cms.Services.Models.Article>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
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
                    <a href="index.html">添加文章</a>
                    <i class="icon-angle-right"></i>
                </li>
                <li><a href="#">文章管理</a></li>

            </ul>
            <!-- END PAGE TITLE & BREADCRUMB-->
        </div>
    </div>
    <div class="row-fluid">
        <% using (Html.Form(new { @class = "form-horizontal" }))
           { %>
        <%: Html.AntiForgeryToken()%>
        <%: Html.ValidationSummary(true)%>

        <fieldset>
            <legend>文章信息</legend>

            <div class="control-group">
                <label class="control-label"><%: Html.LabelFor(model => model.Title)%></label>
                <div class="controls">
                    <%: Html.EditorFor(model => model.Title)%>
                    <span class="help-inline"><%: Html.ValidationMessageFor(model => model.Title)%></span>
                </div>
            </div>

            <div class="control-group">
                <label class="control-label"><%: Html.LabelFor(model => model.Content)%></label>
                <div class="controls">
                    <%: Html.EditorFor(model => model.Content)%>
                    <span class="help-inline"><%: Html.ValidationMessageFor(model => model.Content)%></span>
                </div>
            </div>

            <div class="control-group">
                <label class="control-label"><%: Html.Label("选择类别")%></label>
                <div class="controls">
                    <%var cates = ViewBag.Categorys as List<Hetao.Framework.Cms.Services.Models.Category>; %>
                    <%foreach (var c in cates)
                      {%>
                    <span>
                        <%:Html.Label(c.CategoryName) %>
                        <%:Html.CheckBox("cates") %>

                    </span>
                    <% } %>
                    <span class="help-inline"><%: Html.ValidationMessageFor(model => model.Content)%></span>
                </div>
            </div>

            <div class="form-actions">
                <button type="submit" class="btn blue"><i class="icon-ok"></i>保存</button>

                <a href="<%:Url.BackUrl() %>" class="btn">返回</a>
            </div>


        </fieldset>
        <% } %>
    </div>

</asp:Content>
