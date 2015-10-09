using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Reflection;
using Hetao.Framework.Web.Extensions;

namespace System.Web.Mvc
{
    public static class EasyUIGirdExtensions
    {
        public static EasyUIGrid<T> EasyUIGrid<T>(this HtmlHelper helper, IEnumerable<T> list)
        {
            return new EasyUIGrid<T>(list);
        }

    }
}
