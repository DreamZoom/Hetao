using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Utility;
using Webdiyer.WebControls.Mvc;

namespace System.Web.Mvc
{
    /*
     * 控制器方法扩展
     * 
     * 
     * 
     * */
    public static class ControllerExtensions
    {
        /// <summary>
        /// 序列化json格式，兼容jsonp
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static ActionResult JsonSerialize(this Controller controller, object o)
        {
            string callback = controller.Request.Params["callback"];
            if (string.IsNullOrWhiteSpace(callback))
            {
                return new ContentResult() { Content = JsonHelper.Serialize(o) };
            }
            else
            {
                return new ContentResult() { Content = string.Format("{0}({1})", callback, JsonHelper.Serialize(o)) };
            }
        }

        public static object ConvertEasyUIList<T>(Webdiyer.WebControls.Mvc.IPagedList<T> list)
        {
            return new
            {
                rows = list,
                total = list.TotalItemCount
            };
        }


        /// <summary>
        /// 将数据转换成easyui所需格式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controller"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static ActionResult JsonEasyUIList<T>(this Controller controller, IPagedList<T> list)
        {
            return JsonSerialize(controller,ConvertEasyUIList(list));
        }

        public static ActionResult JsonEasyUIList<T>(this Controller controller, IEnumerable<T> list)
        {
            return JsonSerialize(controller, new PagedList<T>(list, 1, list.Count()));
        }


        #region 结果提示

        public static ActionResult Json(this Controller controller,object data, string message="",bool result=true)
        {
            return JsonSerialize(controller, new { data = data, result = result, message = message });
        } 

        public static ActionResult Error(this Controller controller, string message)
        {
            return Json(controller,null,message,false);
        }

        public static ActionResult Success(this Controller controller, string message)
        {
            return Json(controller, null, message);
        }

        #endregion
    }
}
