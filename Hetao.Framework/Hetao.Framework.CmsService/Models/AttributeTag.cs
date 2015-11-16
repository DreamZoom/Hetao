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

    public enum AttributeTagType
    {
        Category,//类别
        Content,//内容
        Attribute//属性

    }

    /// <summary>
    /// 特性标签
    /// </summary>
    public class AttributeTag : ModelBase
    {
        public AttributeTag()
        {
            this.Sort = 99;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int Id { get; set; }

        /// <summary>
        /// 特性名称
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 是否是系统特性
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int Sort { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}
