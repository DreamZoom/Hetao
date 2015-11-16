using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.BLL;

namespace Hetao.Framework.CmsService
{
    public class ResourceService : ServiceBase<Resource>
    {
        public ResourceService()
            :base(new CmsContext())
        {

        }
    }
}
