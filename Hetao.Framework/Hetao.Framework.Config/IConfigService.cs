using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hetao.Framework.Config
{
    public interface IConfigService<T>
    {
        void SaveConfig(T config);
        T GetConfig();
    }
}
