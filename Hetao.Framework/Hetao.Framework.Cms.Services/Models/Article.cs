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
        public string Title { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 上传时间
        /// </summary>
        [Hidden(EnableMode.Edit )]
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 最近修改
        /// </summary>
        [Hidden(EnableMode.Edit)]
        public DateTime LastUpdateTime { get; set; }


        /// <summary>
        /// 点击数
        /// </summary>
        [Hidden(EnableMode.Edit)]
        public int ClickCount { get; set; }

        /// <summary>
        /// 资源分类
        /// </summary>
        public virtual ICollection<Category> Categorys { get; set; }
       
    }
}
