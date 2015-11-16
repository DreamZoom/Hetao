using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace Hetao.Framework.Web.Auth
{
    public interface IAuthor
    {
        /// <summary>
        /// 获取管理员名称
        /// </summary>
        /// <returns></returns>
        string getName();

        /// <summary>
        /// 获取登录页
        /// </summary>
        /// <returns></returns>
        string getLoginUrl(RequestContext requestContext);
        /// <summary>
        /// 判断是否对当前上下文具有操作权限
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        bool hasAuth(HttpContextBase httpContext);

        /// <summary>
        /// 获得其他信息
        /// </summary>
        /// <returns></returns>
        string getInfo();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="remember"></param>
        /// <returns></returns>
        bool LogIn(string username,string password,bool remember);

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        void LogOut();

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        bool ChangePassword(string password,string newpassword);
    }
}
