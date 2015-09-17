using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.BLL;

namespace Hetao.Framework.Cms.Services
{
    public class CategoryService  :ServiceBase<Models.Category>
    {
        public CategoryService()
            :base(new Models.CmsContext())
        {

        }
    }
}
