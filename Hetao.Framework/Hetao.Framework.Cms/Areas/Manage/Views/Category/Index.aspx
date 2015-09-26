<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    类别管理
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row-fluid">
        <div class="span12">

            <!-- BEGIN PAGE TITLE & BREADCRUMB-->
            <h3 class="page-title">类别管理				
						
                            <small>Categorys</small>
            </h3>
            <ul class="breadcrumb">
                <li>
                    <i class="icon-home"></i>
                    <a href="#">类别管理</a>
                    <i class="icon-angle-right"></i>
                </li>
                <li><a href="#">分类列表</a></li>

            </ul>
            <!-- END PAGE TITLE & BREADCRUMB-->
        </div>
    </div>
    <!-- 列表-->
    <div class="row-fluid">
        <div class="span12">

            <table class="easyui-treegrid" id="categorys_list" idfield="Id" treefield="CategoryName" remotesort="true" selectoncheck="true" checkonselect="true" url='<%:Url.Action("GetTreeCategorys") %>'>
                <thead>
                    <tr>
                        <th data-options="field:'ck',checkbox:true">全选</th>
                        <th data-options="field:'Id'">编号</th>
                        <th data-options="field:'CategoryName'">类别名称</th>
                        <th data-options="field:'Sort'">排序</th>
                    </tr>
                </thead>

            </table>
        </div>
    </div>
    <p></p>
    <div class="row-fluid">
        <div class="span12">
            <p>
                <button type="button" class="btn" id="btn_create" onclick="onCreate()">添加</button>
                <button type="button" class="btn red" id="btn_edit">编辑</button>
                <button type="button" class="btn blue" id="btn_delete">修改</button>
                
            </p>
        </div>
    </div>
    <div id="modal_create" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel1" aria-hidden="true">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
            <h3 id="myModalLabel1">类别信息</h3>
        </div>
        <div class="modal-body">
            <p>Body goes here...</p>
        </div>
        <div class="modal-footer">
            <button class="btn" data-dismiss="modal" aria-hidden="true">关闭</button>
            <button class="btn yellow">保存</button>
        </div>
    </div>
    <script type="text/javascript">
        function getSelect() {
            var row = $("#categorys_list").treegrid("getSelected");
            return row;
        }

        function onCreate() {
            var row = getSelect();
            if (row) {
                alert(row.Id);
            }
        }

        function onEdit() {

        }

        function onDelete() {

        }
    </script>
</asp:Content>
