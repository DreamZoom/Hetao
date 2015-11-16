using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Routing;


namespace Hetao.Framework.Web.Auth
{
    public class DefaultAuther : IAuthor
    {
        /// <summary>
        /// 获取管理员名称
        /// </summary>
        /// <returns></returns>
        public virtual string getName()
        {
            return "系统管理员";
        }

        public virtual string getLoginUrl(RequestContext requestContext)
        {
            UrlHelper Url = new UrlHelper(requestContext);
            return Url.Action("Login");
        }

        /// <summary>
        /// 判断是否对当前上下文具有操作权限
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public virtual bool hasAuth(HttpContextBase httpContext)
        {
            if (httpContext.Session["Admin"] != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获得其他信息
        /// </summary>
        /// <returns></returns>
        public virtual string getInfo()
        {
            return string.Empty;
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="remember"></param>
        /// <returns></returns>
        public virtual bool LogIn(string username, string password, bool remember)
        {
            string pass = System.Web.Configuration.WebConfigurationManager.AppSettings["Admin"];
            if (username == "Admin" && password == pass)
            {
                HttpContext.Current.Session["Admin"] = "Admin";
                return true;
            }

            return false;
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public virtual void LogOut()
        {
            HttpContext.Current.Session["Admin"] = null;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        public virtual bool ChangePassword(string password, string newpassword)
        {
            string pass = System.Web.Configuration.WebConfigurationManager.AppSettings["Admin"];
            if (HttpContext.Current.Session["Admin"] != null)
            {
                if (password == pass)
                {
                    System.Web.Configuration.WebConfigurationManager.AppSettings["Admin"] = newpassword;
                    HttpContext.Current.Session["Admin"] = "Admin";
                    return true;
                }
            }
            return false;
        }
    }
}
