<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%if (ViewBag.MsgType == "success")
      { %>
    <div class="alert alert-success">
        <button class="close" data-dismiss="alert"></button>
        <strong>Success!</strong> The page has been added.
    </div>
    <%}
      else
      { %>
    <div class="alert">
        <button class="close" data-dismiss="alert"></button>
        <strong>Warning!</strong>
        <%: ViewBag.Message %>
        <a href="<%:ViewBag.BackUrl %>" class=" ">返回</a>
    </div>
    <%} %>
</asp:Content>
