using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hetao.Framework.Web;
using Hetao.Framework.SamplePermission;

namespace Hetao.Framework.Cms.Areas.Manage.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Manage/Main/
        [AuthFilter("admin", "/manage/main/login")]
        public ActionResult Index()
        {
            return View();
        }

        [AuthFilter("admin", "/manage/main/login")]
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
                var AccountService = new AccountService();
                var admin = AccountService.Login(username, password,"Admin");

                
                Session["admin"] = admin;

                if (admin != null)
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
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }

            return View();
        }


        public ActionResult Logout()
        {
            Session["admin"] = null;
            return RedirectToAction("Login");
        }

    }
}
