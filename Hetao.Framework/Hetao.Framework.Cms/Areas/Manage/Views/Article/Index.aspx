<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Hetao.Framework.Cms.Services.Models.Article>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Content) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Title) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.AddTime) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.LastUpdateTime) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.ClickCount) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Content) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Title) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.AddTime) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.LastUpdateTime) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ClickCount) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.Id }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.Id }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.Id }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
