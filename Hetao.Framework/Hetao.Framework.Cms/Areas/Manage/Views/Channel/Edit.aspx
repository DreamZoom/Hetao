<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/_Edit.Master" Inherits="System.Web.Mvc.ViewPage<Hetao.Framework.CmsService.Channel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%: Html.HiddenFor(model => model.Id) %>

    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.ChannelName) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.ChannelName) %>
                <%: Html.ValidationMessageFor(model => model.ChannelName) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>
    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Parent) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.DropDownList("Parent_Id","请选择频道...") %>
                <%: Html.ValidationMessageFor(model => model.Parent_Id) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>
    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Sort) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Sort) %>
                <%: Html.ValidationMessageFor(model => model.Sort) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>




</asp:Content>
