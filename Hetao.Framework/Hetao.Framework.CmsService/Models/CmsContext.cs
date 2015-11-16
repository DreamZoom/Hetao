using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.DAL;
using System.Data.Entity;

namespace Hetao.Framework.CmsService
{
    public class CmsContext : DbContextBsae
    {
        public CmsContext()
            : base("CmsConnection")
        {

        }

        DbSet<AttributeTag> AttributeTags { get; set; }

        DbSet<Resource> Resources { get; set; }

        DbSet<Channel> Channels { get; set; }

    }
}
