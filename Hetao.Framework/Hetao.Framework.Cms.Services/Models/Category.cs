using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hetao.Framework.Cms.Services.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public int Sort { get; set; }

        [ForeignKey("Category")]
        public int ParentId { get; set; }
        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Childs { get; set; }
    }
}
