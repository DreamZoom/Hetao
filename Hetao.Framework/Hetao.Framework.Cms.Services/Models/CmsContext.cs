using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.DAL;
using System.Data.Entity;

namespace Hetao.Framework.Cms.Services.Models
{
    public class CmsContext : DbContextBsae
    {
        public CmsContext()
            : base("CmsConnection")
        {

        }

        DbSet<Article> Articles { get; set; }

        DbSet<Category> Categorys { get; set; }

        DbSet<Navigation> Navigations { get; set; }
    }
}
