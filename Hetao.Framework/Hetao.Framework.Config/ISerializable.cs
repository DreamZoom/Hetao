using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hetao.Framework.Config
{
    public interface ISerializable
    {
        void Save(IConfig config);
        IConfig Get();
    }
}
