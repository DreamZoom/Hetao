using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Hetao.Framework.Utility
{
    public class XmlHelper
    {
        /// <summary>
        /// 加载xml文档，并忽略注释
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static XmlDocument Load(string path)
        {

            if (!File.Exists(path)) return null;

            using (StreamReader tr = new StreamReader(path))
            {
                XmlDocument doc = new XmlDocument();
                XmlReaderSettings xst = new XmlReaderSettings();
                xst.IgnoreComments = true;

                XmlReader xr = XmlReader.Create(tr, xst);
                doc.Load(xr);

                return doc;
            }


        }
    }
}
