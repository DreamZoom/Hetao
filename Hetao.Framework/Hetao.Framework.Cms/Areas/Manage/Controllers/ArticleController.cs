using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hetao.Framework.Cms.Services;
using Hetao.Framework.Cms.Services.Models;
using Hetao.Framework.Web;
namespace Hetao.Framework.Cms.Areas.Manage.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Manage/Article/

        ArticleService articleService = new ArticleService();
        public ActionResult Index(int page=1, int pageSize = 20)
        {
            var list = articleService.FindAllByPage(Request, pageSize, page);
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Article article,string cates)
        {
            return View();
        }

    }
}
