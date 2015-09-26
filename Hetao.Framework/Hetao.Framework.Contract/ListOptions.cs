using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetao.Framework.Contract
{
    public class EasyUIPageOptions
    {
        private int page = 1;

        public int Page
        {
            get { return page; }
            set { page = value; }
        }


        private int pagesize = 20;

        public int PageSize
        {
            get { return pagesize; }
            set { pagesize = value; }
        }

        private int rows = 20;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        
    }
}
