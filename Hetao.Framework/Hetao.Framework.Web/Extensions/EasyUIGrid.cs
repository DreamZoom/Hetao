using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Reflection;
using System.Data;

namespace Hetao.Framework.Web.Extensions
{
    public class EasyUIGrid<T> : IDisposable
    {
        Dictionary<String, Func<object, T, string>> Formatter { get; set; }

        Func<T, String> Actions { get; set; }
        public EasyUIGrid(IEnumerable<T> list)
        {
            this.DataList = list;
            this.CheckBoxMode = 2;//2位多选

            //属性过滤器
            Formatter = new Dictionary<string, Func<object, T, string>>();

            Actions = null;
        }

        private IEnumerable<T> DataList { get; set; }

        public int CheckBoxMode { get; set; }
        public MvcHtmlString Render()
        {
            var propertys = typeof(T).GetProperties();

            propertys = propertys.Where(m=>m.PropertyType.IsPrimitive|| m.PropertyType==typeof(string)).ToArray();

            #region 表头
            List<string> headers = propertys.ToList().ConvertAll(m => getFiledName(m));

            if (this.CheckBoxMode > 0)
            {
                headers.Insert(0, string.Format("<th field=\"{0}\" checkbox=\"true\"></th>", "ck"));
            }

            if (this.Actions != null)
            {
                headers.Add(string.Format("<th field=\"{0}\" width=\"300px\">操作</th>", "actions"));
            }

            string tHead = string.Format("<thead><tr>{0}</tr></thead>", string.Join("", headers));

            #endregion

            StringBuilder tBody = new StringBuilder();
            tBody.AppendLine("<table class=\"easyui-datagrid\" fitColumns=\"true\"  >");
            tBody.AppendLine(tHead);
            tBody.AppendLine("<tbody>");
            foreach (var model in DataList)
            {
                List<string> tds = propertys.ToList().ConvertAll(m => getFiledValue(m, model));

                if (this.CheckBoxMode > 0)
                {
                    tds.Insert(0, string.Format("<td>{0}</td>", ""));
                }
                if (this.Actions != null)
                {
                    tds.Add(string.Format("<td>{0}</td>", this.Actions(model)));
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

        private string getFiledValue(PropertyInfo property, T model)
        {
            var value = property.GetValue(model, null);
            if (Formatter.ContainsKey(property.Name))
            {
                return string.Format("<td>{0}</td>", Formatter[property.Name](value,model));
            }
            return string.Format("<td>{0}</td>", value);
        }


        public EasyUIGrid<T> Format(string propertyName,Func<object,T,string> formatter)
        {
            this.Formatter[propertyName] = formatter;
            return this;
        }
        public EasyUIGrid<T> Action(Func<T, string> actions)
        {
            this.Actions = actions;
            return this;
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
