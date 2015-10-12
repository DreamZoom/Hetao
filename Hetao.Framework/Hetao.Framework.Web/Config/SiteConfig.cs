using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Config;

namespace Hetao.Framework.Web.Config
{
    public class SiteConfig : IConfig
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Discription { get; set; }

        /// <summary>
        /// 版权信息
        /// </summary>
        public string Copyright { get; set; }
    }
}
