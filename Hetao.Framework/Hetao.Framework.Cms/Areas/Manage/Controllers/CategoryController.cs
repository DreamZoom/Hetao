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
    public class CategoryController : ManageControllerBase<Category>
    {
        //
        // GET: /Manage/Category/

        public ActionResult Index()
        {
            return View();
        }

        public override Hetao.Framework.BLL.ServiceBase<Hetao.Framework.Cms.Services.Models.Category> InitService()
        {
            return new CategoryService();
        }


    }
}
