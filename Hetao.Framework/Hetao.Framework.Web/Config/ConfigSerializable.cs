using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Hetao.Framework.Utility;

namespace Hetao.Framework.Config
{
    public class ConfigSerializable<T> : ISerializable
       where T : IConfig
    {
        public static string ConfigPath { get; set; }
        private Type type;
        public ConfigSerializable()
        {
            this.type = typeof(T);
        }
        public void Save(IConfig config)
        {
            CheckPath();
            string name = type.Name;
            string content = SerializationHelper.XmlSerialize(config);
            string file = ConfigPath + name + ".xml";
            File.WriteAllText(file, content);
        }

        public IConfig Get()
        {
            CheckPath();
            string name = type.Name;
            string file = ConfigPath + name + ".xml";
            string content = File.ReadAllText(file);
            return (T)SerializationHelper.XmlDeserialize(typeof(T), content);
        }

        private void CheckPath()
        {
            if (string.IsNullOrWhiteSpace(ConfigPath))
            {
                ConfigPath = System.Web.HttpContext.Current.Server.MapPath("/Config");
            }
        }
    }
}
