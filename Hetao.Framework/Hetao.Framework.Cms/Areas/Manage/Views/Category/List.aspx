<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Hetao.Framework.Cms.Services.Models.Category>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>

    <%:Html.EasyUIGrid(Model).Render() %>
    <table id="dg" class="easyui-datagrid" style="width:700px;height:auto;border:1px solid #ccc;">
        <thead>
            <tr>
                <th data-options="field:'itemid',checkbox:'true'">Item ID</th>
                <th data-options="field:'productid'">Product</th>
                <th data-options="field:'listprice',align:'right'">List Price</th>
                <th data-options="field:'attr1'">Attribute</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>EST-1</td><td>FI-SW-01</td><td>36.50</td><td>Large</td>
            </tr>
            <tr>
                <td>EST-10</td><td>K9-DL-01</td><td>18.50</td><td>Spotted Adult Female</td>
            </tr>
            <tr>
                <td>EST-11</td><td>RP-SN-01</td><td>28.50</td><td>Venomless</td>
            </tr>
            <tr>
                <td>EST-12</td><td>RP-SN-01</td><td>26.50</td><td>Rattleless</td>
            </tr>
            <tr>
                <td>EST-13</td><td>RP-LI-02</td><td>35.50</td><td>Green Adult</td>
            </tr>
        </tbody>
    </table>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.CategoryName) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Sort) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.CategoryName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Sort) %>
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
