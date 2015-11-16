using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hetao.Framework.Contract;
using Hetao.Framework.Web;

namespace Hetao.Framework.CmsService
{
    public enum ResourceType
    {
        article,
        video,
        music,
        images,
        unkown
    }
    public class Resource : ModelBase
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name="编号")]
        public int Id { get; set; }

        [Display(Name = "标题")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "介绍")]
        public string Summary { get; set; }


        [Display(Name = "内容")]
        [Required]
        public string Content { get; set; }

        [Display(Name = "资源类型")]
        public ResourceType ResourceType { get; set; }

        [Display(Name = "创建时间")]
        public DateTime AddTime { get; set; }

        [Display(Name = "访问数")]
        public int Reads { get; set; }

        /// <summary>
        /// 频道
        /// </summary>
        /// 
         [Display(Name = "频道Id")]
        public int Channel_Id { get; set; }
        public virtual Channel Channel { get; set; }

        public virtual ICollection<AttributeTag> Tags { get; set; }
    }
}
