using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Config;
using System.Xml.Serialization;
using System.Web.Mvc;

namespace Hetao.Framework.Web.Config
{

    public class AdminMenuService : XmlConfigService<AdminMenuConfig>
    {
        private static AdminMenuService _current = null;

        public static AdminMenuService Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new AdminMenuService();
                }
                return AdminMenuService._current;
            }
            set { AdminMenuService._current = value; }
        }


        public MenuNode getMenuNode(string controllerName, string actionName)
        {
            AdminMenuConfig config = this.GetConfig();

            foreach (var Menu in config.Nodes)
            {

                if (Menu.IsGroup)
                {
                    var node = Menu.Menus.FirstOrDefault(m => m.ControllerName == controllerName && m.ActionName == actionName);
                    if (node != null)
                    {
                        node.Parent = Menu;
                        return node;
                    }
                }
                else
                {
                    if (Menu.ControllerName == controllerName && Menu.ActionName == actionName)
                    {
                        return Menu;
                    }
                }

            }

            return null;
        }

        public MenuNode getMenuNode(HtmlHelper helper)
        {
            var controller = helper.ViewContext.RouteData.Values["controller"].ToString();
            var action = helper.ViewContext.RouteData.Values["action"].ToString();
            return getMenuNode(controller, action);
        }
    }

    public class AdminMenuConfig : IConfig
    {
        public AdminMenuConfig()
        {
            this.Nodes = new List<MenuNode>();
        }
        public List<MenuNode> Nodes { get; set; }
    }


    public class MenuNode
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Descript { get; set; }
        [XmlAttribute]
        public string ControllerName { get; set; }
        [XmlAttribute]
        public string ActionName { get; set; }

        [XmlAttribute]
        public int ShowMode { get; set; }

        public MenuNode Parent { get; set; }

        public List<MenuNode> Menus { get; set; }
        [XmlAttribute]
        public bool IsGroup { get; set; }

        public bool IsCurrent(HtmlHelper helper)
        {
            var controller = helper.ViewContext.RouteData.Values["controller"].ToString();
            var action = helper.ViewContext.RouteData.Values["action"].ToString();
            return this.ControllerName == controller && this.ActionName == action;
        }

        public bool IsGroupCurrent(HtmlHelper helper)
        {

            return this.Menus.Where(m => m.IsCurrent(helper)).Count() > 0;
        }

    }

    
}
