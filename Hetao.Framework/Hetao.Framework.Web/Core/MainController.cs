using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Hetao.Framework.Web.Auth;

namespace Hetao.Framework.Web.Core
{
    public class MainController : Controller
    {
        [AuthorFilter()]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorFilter()]
        public ActionResult Center()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password, bool remember = false)
        {
            try
            {
                if (AuthorProvider.Admin.LogIn(username, password, remember))
                {
                    string url = Request.Params["back_url"];
                    if (!string.IsNullOrWhiteSpace(url))
                    {
                        return Redirect(url);
                    }
                    else
                    {
                        return RedirectToAction("center");
                    }
                }
                else
                {
                    ViewData.ModelState.AddModelError("", "用户名或密码错误");
                }
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }

            return View();
        }


        public ActionResult Logout()
        {
            AuthorProvider.Admin.LogOut();
            return RedirectToAction("Login");
        }

        [AuthorFilter]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [AuthorFilter]
        public ActionResult ChangePassword(string password,string newpassword)
        {
            try
            {
                if (AuthorProvider.Admin.ChangePassword(password, newpassword))
                {
                    //重新登录
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewData.ModelState.AddModelError("", "密码错误");
                }
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }

            return View();
        }
    }
}
