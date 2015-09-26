using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static class HtmlFromExtensions
    {
        public static MvcForm Form(this HtmlHelper helper,object attributes)
        {
            var controllter = helper.ViewContext.RouteData.Values["controller"].ToString();
            var action = helper.ViewContext.RouteData.Values["action"].ToString();
            return helper.BeginForm(action, controllter, FormMethod.Post, attributes);
        }
    }
}
