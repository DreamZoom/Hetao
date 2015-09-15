using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Hetao.Framework.Contract;
using Hetao.Framework.DAL;
using Hetao.Framework.BLL;

namespace Hetao.Framework.Web
{
    
    public class ManageControllerBase<T> : Controller
        where T : ModelBase
    {
        protected ServiceBase<T> Service { get; set; }

        public Type ModelType { get; set; }
        public ManageControllerBase(DbContextBsae context)
        {
            Service = new ServiceBase<T>(context);
            ModelType = typeof(T);
            
        }

        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Create()
        {
            ViewData.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null, ModelType);
            return View();
        }

        [HttpPost]
        public ActionResult Create(T model)
        {
            try
            {
                Service.Insert(model);
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }
            return View();
        }

        public ActionResult Edit()
        {
            ViewData.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null, ModelType);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(T model)
        {
            try
            {
                Service.Update(model);
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }
            return View();
        }

    }
}
