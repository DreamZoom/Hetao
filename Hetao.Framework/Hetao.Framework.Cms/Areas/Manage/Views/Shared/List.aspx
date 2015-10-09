<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/Frame.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Hetao.Framework.Contract.ModelBase>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>List</h2>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <%:Html.EasyUIGrid(Model) %>

</asp:Content>
