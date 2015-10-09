using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hetao.Framework.Contract;

namespace Hetao.Framework.Cms.Services.Models
{
    public class Category : ModelBase
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public int Sort { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
