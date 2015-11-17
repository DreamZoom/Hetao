using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hetao.Framework.Contract;
using Hetao.Framework.Web;

namespace Hetao.Framework.CmsService
{
    /// <summary>
    /// 频道
    /// </summary>
    public class Channel : ModelBase
    {

        public Channel()
        {
            this.Sort = 99;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int Id { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        [Display(Name = "频道名称")]
        [Required]
        public string ChannelName { get; set; }

        
        /// <summary>
        /// 父级Id
        /// </summary>
        /// 
        [Display(Name = "上级频道Id")]
        public int Parent_Id { get; set; }
        [Display(Name = "上级频道")]
        [ForeignKey("Parent_Id")]
        public virtual Channel Parent { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        [Display(Name = "排序号")]
        public int Sort { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }

    }
}
