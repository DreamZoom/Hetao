<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Hetao.Framework.Contract.ModelBase>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.ViewData.ModelMetadata.ModelType.Name%>
            <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
