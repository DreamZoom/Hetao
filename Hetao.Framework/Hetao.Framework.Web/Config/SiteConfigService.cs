using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Config;

namespace Hetao.Framework.Web.Config
{
    public class SiteConfigService : XmlConfigService<SiteConfig>
    {

        private static SiteConfigService _current=null;

        public static SiteConfigService Current
        {
            get {
                if (_current == null)
                {
                    _current = new SiteConfigService();
                }
                return SiteConfigService._current;
            }
            set { SiteConfigService._current = value; }
        }
        public string[] getKeywords()
        {
            SiteConfig config = GetConfig();
            return config.Keywords.Split(',');
        }
    }
}
