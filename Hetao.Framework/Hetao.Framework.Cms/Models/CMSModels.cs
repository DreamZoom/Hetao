using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hetao.Framework.Cms.Models
{
    /// <summary>
    /// 资源
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// 资源ID
        /// </summary>
        /// 
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 资源标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public int AddTime { get; set; }

        /// <summary>
        /// 最近修改
        /// </summary>
        public int LastUpdateTime { get; set; }

        /// <summary>
        /// 资源分类
        /// </summary>
        public virtual ICollection<Category> Categorys { get; set; }
    }

    /// <summary>
    /// 资源分类
    /// </summary>
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string CateName { get; set; }

        public int Sort { get; set; }

        [ForeignKey("Category")]
        public int ParentId { get; set; }
        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Childs { get; set; }

    }


}
