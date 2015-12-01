<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/Manage/Views/Shared/_List.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Hetao.Framework.CmsService.Resource>>" %>

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
                        <th>
                            标题
                        </th>
                        <th>
                            频道
                        </th>
                        <th>
                            简介
                        </th>
                        <th>
                            资源类型
                        </th>
                        <th>
                            创建时间
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
                            <%:m.Title%>
                        </td>
                        <td>
                            <%:m.Channel==null?"":m.Channel.ChannelName%>
                        </td>
                        <td>
                            <%:m.Summary%>
                        </td>
                        <td>
                            <%:m.ResourceType%>
                        </td>
                        <td>
                            <%:m.AddTime%>
                        </td>
                        <td>
                            <a class="btn mini purple thickbox" title='编辑内容' href="<%:Url.Action("Edit", new { id = m.Id })%>">
                                <i class="icon-edit"></i>
                                编辑内容
                            </a>
                             <a class="btn mini purple thickbox" title='编辑标签' href="<%:Url.Action("UpdateTags", new { id = m.Id })%>">
                                <i class="icon-edit"></i>
                                编辑标签
                            </a>
                        </td>
                    </tr>
                    <%}%>
                </tbody>
            </table>
        </div>
    </div>


</asp:Content>
