using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Reflection;

namespace System.Web.Mvc
{
    public static class EasyUIGirdExtensions
    {
        public class EasyUIGridOptions
        {
            public bool ShowCheckBox { get; set; }
        }
        public static MvcHtmlString EasyUIGrid<T>(this HtmlHelper helper, IEnumerable<T> list, EasyUIGridOptions options = null)
        {
            #region 设置默认参数
            if (options == null)
            {
                options = new EasyUIGridOptions()
                {
                    ShowCheckBox = true
                };
            }
            #endregion


            Type type = list.GetType().GetGenericArguments().FirstOrDefault();

            var propertys = type.GetProperties();

            #region 表头
            List<string> headers = propertys.ToList().ConvertAll(m => getFiledName(m));

            if (options.ShowCheckBox)
            {
                headers.Add(string.Format("<th field=\"{0}\" checkbox=\"true\"></th>", "ck"));
            }
            string tHead = string.Format("<thead><tr>{0}</tr></thead>", string.Join("", headers));

            #endregion

            StringBuilder tBody = new StringBuilder();
            tBody.AppendLine("<table class=\"easyui-datagrid\" fit=\"false\" pagination=\"true\" >");
            tBody.AppendLine(tHead);
            tBody.AppendLine("<tbody>");
            foreach (var model in list)
            {
                List<string> tds = propertys.ToList().ConvertAll(m => getFiledValue(m, model));
                tds.Add(string.Format("<td>{0}</td>", ""));
                tBody.AppendLine(string.Format("<tr>{0}</tr>", string.Join("", tds)));
            }
            tBody.AppendLine("</tbody>");
            tBody.AppendLine("</table>");
            return MvcHtmlString.Create(tBody.ToString());
        }

        private static string getFiledName(PropertyInfo property)
        {
            return string.Format("<th field=\"{0}\">{0}</th>", property.Name);
        }

        private static string getFiledValue(PropertyInfo property, object model)
        {
            return string.Format("<td>{0}</td>", property.GetValue(model,null));
        }
    }
}
