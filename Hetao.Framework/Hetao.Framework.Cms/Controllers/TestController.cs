using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hetao.Framework.Contract;
using Hetao.Framework.DAL;
using Hetao.Framework.BLL;
using Hetao.Framework.Web;

namespace Hetao.Framework.Cms.Controllers
{
    public class TestController : ManageControllerBase<Models.Test>
        
    {
        public TestController()
            :base(new Models.TestContext())
        {

        }
        

    }
}
