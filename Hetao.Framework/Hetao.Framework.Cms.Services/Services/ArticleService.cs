using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.BLL;

namespace Hetao.Framework.Cms.Services
{
    public class ArticleService : ServiceBase<Models.Article>
    {
        public ArticleService()
            :base(new Models.CmsContext())
        {

        }
    }
}
