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
    /// <summary>
    /// 导航
    /// </summary>
    public class Navigation : ModelBase
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }

        public string Title { get; set; }

        public string NavigationUrl { get; set; }

        public virtual Navigation Parent { get; set; }

        public virtual ICollection<Navigation> Childs { get; set; }

    }
}
