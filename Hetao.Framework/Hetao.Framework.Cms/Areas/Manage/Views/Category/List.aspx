<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<Webdiyer.WebControls.Mvc.PagedList<Hetao.Framework.Cms.Services.Models.Category>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>类别列表</h2>

    <div class="row-fluid">
        <div class="span12">
            <%:Html.EasyUIGrid(Model).Action(
       item=>{
            return string.Format("{0}", Html.ActionLink("编辑", "Edit", new { id = item.Id }));
        }).Render() %>
        </div>
    </div>
    <p></p>
    <div class="row-fluid">
        <div class="span4">
            <div class="btn-group" role="group" >
                <%: Html.ActionLink("创建类别", "Create", new { }, new {  @class="btn blue"})%>
                <%: Html.ActionLink("删除", "Create", new { }, new {  @class="btn"})%>
            </div>
            
        </div>
        <div class="span8">
            <%:Html.MvcPager(Model) %>
        </div>
    </div>
</asp:Content>
