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


        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult List()
        {
            var options = new EasyUIPageOptions();
            TryUpdateModel(options);

            var list = Service.FindAllByPage(Request, options.Page, options.PageSize);
            return View(list);
        }

        #region 添加记录
        public virtual ActionResult Create()
        {
            ViewData.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null, ModelType);
            return View();
        }

        [HttpPost]
        public virtual ActionResult Create(T model)
        {
            try
            {
                Service.Insert(model);
                return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }
            return View(model);
        }


        #endregion

        #region 删除记录
        public virtual ActionResult Edit()
        {
            var model = Service.Find(Request);
            if (model == null) return Error("未找到记录");
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Edit(T model)
        {
            try
            {
                Service.Update(model);
                return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }
            return View(model);
        }
        #endregion

        #region 详情
        public virtual ActionResult Details()
        {
            var model = Service.Find(Request);
            if (model == null) return Error("未找到记录");
            return View(model);
        }

        #endregion

        #region 删除记录
        public virtual ActionResult Delete()
        {
            var model = Service.Find(Request);
            if (model == null) return Error("未找到记录");
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Delete(T model)
        {
            try
            {
                Service.Delete(model);
                return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                ViewData.ModelState.AddModelError("", err.Message);
            }
            return View(model);
        }

        #endregion


        #region 结果展示

        public ActionResult Error(string message)
        {
            string lastUrl = Request.UrlReferrer == null ? "" : Request.UrlReferrer.ToString();
            return View("_Result", new { MsgType = "error", Message = message, BackUrl = lastUrl });
        }

        public ActionResult Success(string message)
        {
            string lastUrl = Request.UrlReferrer == null ? "" : Request.UrlReferrer.ToString();
            return View("_Result", new { MsgType = "success", Message = message, BackUrl = lastUrl });
        }


        #endregion
    }
}
