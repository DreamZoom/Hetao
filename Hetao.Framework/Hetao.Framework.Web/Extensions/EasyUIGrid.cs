using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Reflection;

namespace Hetao.Framework.Web.Extensions
{
    public class EasyUIGrid<T> : IDisposable
    {
        public EasyUIGrid(IEnumerable<T> list)
        {
            this.DataList = list;
            this.CheckBoxMode = 2;//2位多选
        }

        private IEnumerable<T> DataList { get; set; }

        public int CheckBoxMode { get; set; }
        public MvcHtmlString Render()
        {
            var propertys = typeof(T).GetProperties();

            #region 表头
            List<string> headers = propertys.ToList().ConvertAll(m => getFiledName(m));

            if (this.CheckBoxMode > 0)
            {
                headers.Insert(0,string.Format("<th field=\"{0}\" checkbox=\"true\"></th>", "ck"));
            }
            string tHead = string.Format("<thead><tr>{0}</tr></thead>", string.Join("", headers));

            #endregion

            StringBuilder tBody = new StringBuilder();
            tBody.AppendLine("<table class=\"easyui-datagrid\"   >");
            tBody.AppendLine(tHead);
            tBody.AppendLine("<tbody>");
            foreach (var model in DataList)
            {
                List<string> tds = propertys.ToList().ConvertAll(m => getFiledValue(m, model));

                if (this.CheckBoxMode > 0)
                {
                    tds.Insert(0,string.Format("<td>{0}</td>", ""));
                }

                tBody.AppendLine(string.Format("<tr>{0}</tr>", string.Join("", tds)));
            }
            tBody.AppendLine("</tbody>");
            tBody.AppendLine("</table>");
            return MvcHtmlString.Create(tBody.ToString());
        }


        private string getFiledName(PropertyInfo property)
        {
            return string.Format("<th field=\"{0}\">{0}</th>", property.Name);
        }

        private string getFiledValue(PropertyInfo property, object model)
        {
            return string.Format("<td>{0}</td>", property.GetValue(model, null));
        }


        public override string ToString()
        {
            return this.Render().ToHtmlString();
        }

        public void Dispose()
        {

        }
    }
}
