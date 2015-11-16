using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.BLL;

namespace Hetao.Framework.CmsService
{
    public class ChannelService : ServiceBase<Channel>
    {
        public ChannelService()
            :base(new CmsContext())
        {

        }
    }
}
