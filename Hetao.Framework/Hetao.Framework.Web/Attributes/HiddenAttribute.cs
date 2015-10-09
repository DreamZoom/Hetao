using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Mvc;

namespace Hetao.Framework.Web
{
    /// <summary>
    /// 用于控制模型是否显示字段
    /// </summary>
    public class HiddenAttribute:Attribute
    {
        public EnableMode Flags { get; set; }

        public HiddenAttribute(EnableMode flags)
        {
            this.Flags = flags;
        }

        public bool CompareFlags(EnableMode flags)
        {
            return (Flags & flags) > 0;
        }

        public static bool HasEnable(PropertyInfo property, EnableMode flags)
        {
            HiddenAttribute attr = property.GetCustomAttribute(typeof(HiddenAttribute)) as HiddenAttribute;
            if (attr != null)
            {
                return attr.CompareFlags(flags);
            }
            return true;
        }

        public static bool HasEnable(Type modelType, string propertyName, EnableMode flags)
        {
            var property = modelType.GetProperty(propertyName);
            if (property == null) return false;

            HiddenAttribute attr = property.GetCustomAttribute(typeof(HiddenAttribute)) as HiddenAttribute;
            if (attr != null)
            {
                return !attr.CompareFlags(flags);
            }
            return true;
        }
    }

    /// <summary>
    /// 显示模式
    /// </summary>
    [Flags]
    public enum EnableMode
    {
        Edit = 1,
        Display = 2,
        List = 4,
        Auto = 8
    } 
}
