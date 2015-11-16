<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/_List.Master" Inherits="System.Web.Mvc.ViewPage<Webdiyer.WebControls.Mvc.PagedList<Hetao.Framework.CmsService.Channel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row-fluid">
        <div class="span12">
            <table class="table table-striped table-hover">
                <thead>
                    <tr>
                        <th style="width: 8px;">
                            <input type="checkbox" id="checkall" class="group-checkable" />
                        </th>
                        <th>频道名称
                        </th>
                        <th>排序号
                        </th>

                        <th>操作
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <%foreach (var m in Model)
                      {%>
                    <tr>
                        <td>
                            <input type="checkbox" class="checkboxes" name='Id' value='<%:m.Id %>' />
                        </td>
                        <td>
                            <%:m.ChannelName%>
                        </td>
                        <td>
                            <%:m.Sort%>
                        </td>

                        <td>
                            <a class="btn mini purple thickbox" title='编辑文章内容' href="<%:Url.Action("Edit", new { id = m.Id })%>">
                                <i class="icon-edit"></i>
                                编辑
                            </a>
                        </td>
                    </tr>
                    <%}%>
                </tbody>
            </table>
        </div>
    </div>


   

</asp:Content>
