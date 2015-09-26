using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Hetao.Framework.Contract;
using Hetao.Framework.DAL;
using Hetao.Framework.BLL;
using Hetao.Framework.Utility;
using Webdiyer.WebControls.Mvc;

namespace Hetao.Framework.Web
{
    public class ApiControllerBase<T> : Controller
         where T : ModelBase
    {
        protected ServiceBase<T> Service { get; set; }

        public Type ModelType { get; set; }
        public ApiControllerBase()
        {
            Service = InitService();
            ModelType = typeof(T);

        }

        public virtual ServiceBase<T> InitService()
        {
            throw new ArgumentException("未初始化Context");
        }
       
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult JsonList()
        {
            var options = new EasyUIPageOptions();
            TryUpdateModel(options);

            var list = Service.FindAllByPage(Request, options.Rows ,options.Page);
            return this.JsonEasyUIList(list);
        }

       

        #region 添加记录

        [HttpPost]
        public virtual ActionResult Create(T model)
        {
            try
            {
                Service.Insert(model);
                return this.Json(model);
            }
            catch (Exception err)
            {
                return this.Error(err.Message);
            }
            
        }


        #endregion

        #region 编辑记录
       

        [HttpPost]
        public virtual ActionResult Edit(T model)
        {
            try
            {
                Service.Update(model);
                return this.Json(model);
            }
            catch (Exception err)
            {
                return this.Error(err.Message);
            }
          
        }
        #endregion

        #region 详情
        public virtual ActionResult Details()
        {
            var model = Service.Find(Request);
            if (model == null) return this.Error("未找到记录");
            return View(model);
        }

        #endregion

        #region 删除记录
       

        [HttpPost]
        public virtual ActionResult Delete(T model)
        {
            try
            {
                Service.Delete(model);
                return this.Json(model);
            }
            catch (Exception err)
            {
                return this.Error(err.Message);
            }
        }

        #endregion

        
    }
}
