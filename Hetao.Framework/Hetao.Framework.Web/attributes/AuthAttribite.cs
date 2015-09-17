using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Hetao.Framework.Web
{

    public class AuthFilter : ActionFilterAttribute
    {
        string sessionID = "";
        string backurl = "";
        string loginurl = "";
        public AuthFilter(string roleID, string loginurl, string backurl = "")
        {
            this.sessionID = roleID;
            this.loginurl = loginurl;
            this.backurl = backurl;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var actionName = filterContext.ActionDescriptor.ActionName;

            var returnUrl = loginurl;
            var url = filterContext.HttpContext.Request.Url.ToString();
            returnUrl += "?back_url=" + (string.IsNullOrWhiteSpace(this.backurl) ? url : this.backurl);

            if (filterContext.HttpContext.Session[sessionID] == null)
            {
                filterContext.Result = new RedirectResult(returnUrl);
                return;
            }
            base.OnActionExecuting(filterContext);
        }

    }
}
