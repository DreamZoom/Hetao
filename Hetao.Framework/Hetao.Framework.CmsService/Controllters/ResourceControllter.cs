using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Web;
using System.Web.Mvc;
namespace Hetao.Framework.CmsService.Controllters
{
    public class ResourceController : ManageControllerBase<Resource, ResourceService>
    {

        public override void ForignKeyData(Resource model )
        {
            ChannelService channelService = new ChannelService();
            var channel = channelService.FindAll();
            ViewBag.Channel_Id = new SelectList(channel, "Id", "ChannelName", "请选择频道...");

            AttributeTagService tagService = new AttributeTagService();
            var tags = tagService.FindAll(m => m.IsSystem);
            ViewBag.Tags = new SelectList(channel, "Id", "ChannelName", "请选择标签");
        }

    }
}
