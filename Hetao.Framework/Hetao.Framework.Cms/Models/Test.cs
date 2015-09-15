using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Contract;
using Hetao.Framework.DAL;
using Hetao.Framework.BLL;
using Hetao.Framework.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Hetao.Framework.Cms.Models
{
    public class Test  :ModelBase
    {
        [Key]
        public string Name { get; set; }
    }

    public class TestContext : DbContextBsae
    {
        public TestContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Test> Tests { get; set; }
    }

    
}
