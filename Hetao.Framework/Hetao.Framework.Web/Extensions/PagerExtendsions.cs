using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace System.Web.Mvc
{
    public static class PagerExtendsions
    {
        public static MvcHtmlString MvcPager<T>(this HtmlHelper helper,IPagedList<T> list)
        {
            return helper.Pager(list, new PagerOptions() { 
                CssClass = "pagination",
                ContainerTagName="div",
                HorizontalAlign= "right",
                PageIndexParameterName = "Page",
                //CurrentPagerItemWrapperFormatString="<li class=\"current\">{0}</li>",
                //NavigationPagerItemWrapperFormatString = "<li>{0}</li>"
            });
        }
    }
}
