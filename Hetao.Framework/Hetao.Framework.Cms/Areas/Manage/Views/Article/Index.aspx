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

            <table  class="easyui-datagrid" remotesort="true" selectOnCheck="true" checkOnSelect="true" url='<%:Url.Action("list") %>' >
                <thead>
                    <tr>
                        <th data-options="field:'ck'">全选</th>
                        <th data-options="field:'itemid'">Item ID</th>
                        <th data-options="field:'productid'">Product</th>
                        <th data-options="field:'listprice',align:'right'">List Price</th>
                        <th data-options="field:'attr1'">Attribute</th>
                    </tr>
                </thead>
                
            </table>
        </div>
    </div>


</asp:Content>
