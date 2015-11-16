using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetao.Framework.Web.Auth
{
    public class AuthorProvider
    {
        private static IAuthor _admin = null;

        public static IAuthor Admin
        {
            get {
                if (_admin == null)
                {
                    _admin = new DefaultAuther();
                }
                return _admin; 
            }
            set { _admin = value; }
        }
    }
}
