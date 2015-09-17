using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.BLL;

namespace Hetao.Framework.Cms.Services.Services
{
    public class NavigationService : ServiceBase<Models.Navigation>
    {
        public NavigationService()
            :base(new Models.CmsContext())
        {

        }

        /// <summary>
        /// 获取顶级导航
        /// </summary>
        /// <returns></returns>
        public List<Models.Navigation> FindFirst()
        {
            return this.FindAll(m=>m.Parent==null);
        }
    }
}
