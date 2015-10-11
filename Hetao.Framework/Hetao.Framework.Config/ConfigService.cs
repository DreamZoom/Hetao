using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetao.Framework.Config
{
    public class ConfigService<T>
        where T : IConfig
    {
        protected ISerializable Serializable { get; set; }

        public T Config { get; set; }
        public ConfigService()
        {
            Serializable = new ConfigSerializable<T>();

            Load();
        }
        public void Save(IConfig config)
        {
            Serializable.Save(config);
        }

        public void Load()
        {
            Config = (T)Serializable.Get();
        }
    }
}
