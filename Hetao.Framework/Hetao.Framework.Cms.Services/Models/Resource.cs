﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hetao.Framework.Contract;

namespace Hetao.Framework.Cms.Services.Models
{
    public class Resource : ModelBase
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
        /// 点击数
        /// </summary>
        public int ClickCount { get; set; }

        /// <summary>
        /// 资源分类
        /// </summary>
        public virtual ICollection<Category> Categorys { get; set; }
    }
}
