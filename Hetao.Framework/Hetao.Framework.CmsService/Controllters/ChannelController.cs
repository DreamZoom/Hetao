using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Web;
using System.Web.Mvc;

namespace Hetao.Framework.CmsService.Controllters
{
    public class ChannelController : ManageControllerBase<Channel, ChannelService>
    {
        public override void ForignKeyData(Channel model)
        {
            var channel = Service.FindAll();
            int id= 0;
            if (model != null)
            {
                channel = channel.Where(m => m.Id != model.Id).ToList();
                id=model.Parent_Id;
            }
            ViewBag.Parent_Id = new SelectList(channel, "Id", "ChannelName", id);
        }
    }
}
