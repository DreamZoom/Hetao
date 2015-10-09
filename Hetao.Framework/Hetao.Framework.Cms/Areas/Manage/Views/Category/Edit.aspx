<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/_Edit.Master" Inherits="System.Web.Mvc.ViewPage<Hetao.Framework.Cms.Services.Models.Category>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%: Html.HiddenFor(model => model.Id) %>

    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.CategoryName) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CategoryName) %>
                <%: Html.ValidationMessageFor(model => model.CategoryName) %>
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
