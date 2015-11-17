<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/_Edit.master" Inherits="System.Web.Mvc.ViewPage<Hetao.Framework.CmsService.Resource>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% 
        var ResourceType = Request["ResourceType"];
        var contentTemplate = "Text";
        var resType = 0;
        if (!string.IsNullOrWhiteSpace(ResourceType))
        {
            resType = int.Parse(ResourceType);

            contentTemplate = ((Hetao.Framework.CmsService.ResourceType)resType).ToString();
        }

        if (Model != null)
        {
            contentTemplate = Model.ResourceType.ToString();
            resType = (int)Model.ResourceType;
        }
    %>


    <%: Html.HiddenFor(model => model.Id) %>
    <%: Html.Hidden("ResourceType",resType) %>
    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Title) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>
    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Channel_Id) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.DropDownList("Channel_Id","请选择频道...") %>
                <%: Html.ValidationMessageFor(model => model.Channel_Id) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>
    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Summary) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Summary) %>
                <%: Html.ValidationMessageFor(model => model.Summary) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>

    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Content) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Content,contentTemplate) %>
                <%: Html.ValidationMessageFor(model => model.Content) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>
    <div class="control-group">
        <label class="control-label"><%:Html.DisplayNameFor(model => model.Reads) %></label>
        <div class="controls">
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Reads) %>
                <%: Html.ValidationMessageFor(model => model.Reads) %>
            </div>
            <span class="help-inline"></span>
        </div>
    </div>

</asp:Content>
