using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Web.Mvc.Html;
using Hetao.Framework.Web;

namespace System.Web.Mvc
{
    public static class HtmlModelExtensions
    {

        /// <summary>
        /// 编辑模型
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static MvcHtmlString EditModel(this HtmlHelper helper,string item_template="")
        {
            var propertys = helper.ViewData.ModelMetadata.Properties;
            StringBuilder sb = new StringBuilder();
            var ModelType =helper.ViewData.ModelMetadata.ModelType;
            foreach (var p in propertys)
            {
                string templateName = string.Empty;

                if (p.ModelType.IsEnum)
                {
                    templateName = "Enum";
                }

                if (!p.ShowForEdit) continue;

                if (p.IsComplexType) continue;

                if (!HiddenAttribute.HasEnable(ModelType, p.PropertyName, EnableMode.Edit)) continue;

                string item =  "<div class=\"control-group\">"
                              +"     <label class=\"control-label\">{0}</label>"
                              +"     <div class=\"controls\">"
                              +"         <div>{1}</div>"
                              +"         <span class=\"help-inline\">{2}</span>"
                              +"     </div>"
                              +" </div>";
                

                if (!string.IsNullOrWhiteSpace(item_template))
                {
                    //0 - 属性名称;1 - 验证结果; 2-输入框
                    item = string.Format(item_template, p.DisplayName ?? p.PropertyName, helper.ValidationMessage(p.PropertyName), helper.Editor(p.PropertyName, templateName));
                }
                else
                {
                    
                    item = string.Format(item, p.DisplayName ?? p.PropertyName,
                                               helper.Editor(p.PropertyName, templateName), 
                                               helper.ValidationMessage(p.PropertyName));

                }
                sb.AppendFormat("{0}", item);
            }
            return new MvcHtmlString(sb.ToString());
        }


        /// <summary>
        /// 修改模型
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static MvcHtmlString ShowModel(this HtmlHelper helper)
        {
            var propertys = helper.ViewData.ModelMetadata.Properties;
            StringBuilder sb = new StringBuilder();
            foreach (var p in propertys)
            {
                string templateName = string.Empty;
                if (p.ModelType.IsEnum)
                {
                    templateName = "Enum";
                }

                if (!p.ShowForDisplay) continue;
                if (p.IsComplexType) continue;

                string item = string.Format("<div class='field-label'>{0}</div>", p.DisplayName ?? p.PropertyName);
                item += string.Format("<div class='field-show'>{0}</div>", helper.Display(p.PropertyName, templateName));
                sb.AppendFormat("<li>{0}</li>", item);
            }
            return new MvcHtmlString(sb.ToString());
        }

    }
}
