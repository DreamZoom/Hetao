using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Hetao.Framework.Web.Auth;

namespace Hetao.Framework.Web
{

    public class AuthorFilter : ActionFilterAttribute
    {
     
        public AuthorFilter()
        {
           
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var actionName = filterContext.ActionDescriptor.ActionName;

            var loginUrl = AuthorProvider.Admin.getLoginUrl(filterContext.RequestContext);
            var url = filterContext.HttpContext.Request.Url.ToString();

            loginUrl += "?back_url=" +  url ;

            AuthorProvider.Admin.hasAuth(filterContext.HttpContext);
            if (!AuthorProvider.Admin.hasAuth(filterContext.HttpContext))
            {
                filterContext.Result = new RedirectResult(loginUrl);
                return;
            }
            base.OnActionExecuting(filterContext);
        }

    }
}
