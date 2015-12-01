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
            : base(new CmsContext())
        {

        }

        public bool UpdateTags(int Id, string[] Tags)
        {
            try
            {
                Tags = Tags.Distinct().ToArray();
                AttributeTagService service = new AttributeTagService(this.DbContext);
               
                foreach (var tag in Tags)
                {
                    var t = service.FindAll(m => m.TagName == tag).FirstOrDefault();
                    if (t == null)
                    {
                        t = service.Insert(new AttributeTag() { TagName = tag, IsSystem = false, Sort = 101 });
                    }
                }

                var res = this.Find(Id);
                foreach (var tag in Tags)
                {
                    var t = service.FindAll(m => m.TagName == tag).FirstOrDefault();
                    if (t != null)
                    {
                        if (!(res.Tags.Where(m => m.TagName == tag).Count() > 0))
                        {
                            res.Tags.Add(t);
                        }
                    }

                }

                this.Update(res);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}
