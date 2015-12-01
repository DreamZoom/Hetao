using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.BLL;
using Hetao.Framework.DAL;

namespace Hetao.Framework.CmsService
{
    public class AttributeTagService : ServiceBase<AttributeTag>
    {
        public AttributeTagService()
            :base(new CmsContext())
        {

        }

        public AttributeTagService(DbContextBsae dbcontext)
            : base(dbcontext)
        {

        }

        public override AttributeTag Update(AttributeTag entity)
        {
            if (entity.IsSystem) throw new ArgumentException("参数错误，系统标签不能编辑.");
            return base.Update(entity);
        }

        public override void Delete(AttributeTag entity)
        {
            if (entity.IsSystem) throw new ArgumentException("参数错误，系统标签不能编辑.");
            base.Delete(entity);
        }


        public override void DeleteList(System.Web.HttpRequestBase request)
        {
           var list = this.FindAllWithIDs(request);
           if (list.Any(m => m.IsSystem)) throw new ArgumentException("参数错误，系统标签不能编辑.");
           base.DeleteList(request);
        }
    }
}
