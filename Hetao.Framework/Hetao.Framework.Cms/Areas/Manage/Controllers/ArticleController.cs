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
    public class ArticleController : ApiControllerBase<Article>
    {

        public override Hetao.Framework.BLL.ServiceBase<Article> InitService()
        {
            return new ArticleService();
        }
        //
        // GET: /Manage/Article/

        
        public ActionResult Index()
        {
            return View();
        }

       

    }
}
