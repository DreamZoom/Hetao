using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Web.Mvc
{
    public static class UrlExtensions
    {
        public static string BackUrl(this UrlHelper helper)
        {
            if (helper.RequestContext.HttpContext.Request.UrlReferrer != null)
            {
                return helper.RequestContext.HttpContext.Request.UrlReferrer.ToString();
            }
            return string.Format("javascript:go(-1);");
        }
    }
}
