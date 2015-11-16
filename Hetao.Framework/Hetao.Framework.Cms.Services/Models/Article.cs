using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hetao.Framework.Contract;
using Hetao.Framework.Web;
namespace Hetao.Framework.Cms.Services.Models
{
    public class Article : ModelBase
    {

        public Article()
        {
            this.LastUpdateTime = DateTime.Now;
            this.AddTime = DateTime.Now;
        }
        /// <summary>
        /// 资源ID
        /// </summary>
        /// 
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Hidden(EnableMode.Edit|EnableMode.Display)]
        public int Id { get; set; }

        /// <summary>
        /// 资源标题
        /// </summary>
        [Display(Name="标题")]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [Display(Name = "摘要")]
        public string Summary { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Display(Name = "文章内容")]
        [Required]
        [Text]
        public string Content { get; set; }
        /// <summary>
        /// 上传时间
        /// </summary>
        [Hidden(EnableMode.Edit )]
        [Display(Name = "创建时间")]
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 最近修改
        /// </summary>
        [Hidden(EnableMode.Edit)]
        [Display(Name = "最近一次修改时间")]
        public DateTime LastUpdateTime { get; set; }


        /// <summary>
        /// 点击数
        /// </summary>
        [Hidden(EnableMode.Edit)]
        [Display(Name = "点击数")]
        public int ClickCount { get; set; }

        /// <summary>
        /// 资源分类
        /// </summary>
        public virtual ICollection<Category> Categorys { get; set; }
       
    }
}
