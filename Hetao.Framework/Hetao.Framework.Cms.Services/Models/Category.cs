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

        public Category()
        {
            this.Sort = 99;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name="类别名称")]
        [Required]
        public string CategoryName { get; set; }

        [Display(Name = "排序号")]
        [Required]
        public int Sort { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
