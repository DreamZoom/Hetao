using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Hetao.Framework.Utility;
namespace System.Web.Mvc
{
    public static class SiteMapExtensions
    {
       
        public static MvcHtmlString SiteMap(this HtmlHelper helper)
        {
            var controllter = helper.ViewContext.RouteData.Values["controller"].ToString();
            var action = helper.ViewContext.RouteData.Values["action"].ToString();
            var area = helper.ViewContext.RouteData.Values["action"].ToString();

            XmlDocument doc = XmlHelper.Load(helper.ViewContext.HttpContext.Request.MapPath(string.Format("~/{0}-web.sitemap",area)));
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<ul class=\"breadcrumb\">");
            if (doc == null)
            {

                sb.AppendFormat("<li><i class=\"icon-home\"></i><a href=\"index.html\">添加文章</a><i class=\"icon-angle-right\"></li>");
            }
            sb.AppendFormat("</ul>");
            return new MvcHtmlString("");
        }


    }

    public class SiteMapNode
    {
        public string action { get; set; }

        public string controller { get; set; }

        public string title { get; set; }
        public string icon { get; set; }

        public string description { get; set; }
    }
}
