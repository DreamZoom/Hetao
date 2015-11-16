using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Web;
using System.Web.Mvc;

namespace Hetao.Framework.Cms.Services.Controllters
{
    public class ArticleController : ManageControllerBase<Models.Article, ArticleService>
    {


    }

    public class CategoryController : ManageControllerBase<Models.Category, CategoryService>
    {
        

    }
}
