using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Contract;
using Hetao.Framework.DAL;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using Webdiyer.WebControls.Mvc;
using System.Web;

namespace Hetao.Framework.BLL
{
    public class ServiceBase<T> 
        where T : ModelBase
    {
        protected DbContextBsae DbContext { get; set; }
        public ServiceBase(DbContextBsae context)
        {
            this.DbContext = context;
        }

        public T Update(T entity)
        {
            return  DbContext.Update(entity);
        }

        public T Insert(T entity) 
        {
            return DbContext.Insert(entity);
        }

        public void Delete(T entity) 
        {
             DbContext.Delete(entity);
        }

        public T Find(params object[] keyValues) 
        {
            return DbContext.Find<T>(keyValues);
        }

        public List<T> FindAll(Expression<Func<T, bool>> conditions = null)
        {
            return DbContext.FindAll<T>(conditions).;
        }

        public PagedList<T> FindAllByPage<S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) 
        {
            return DbContext.FindAllByPage<T, S>(conditions, orderBy, pageSize, pageIndex);
        }


        public T Find(HttpRequestBase request) 
        {
            return DbContext.Find<T>(request);
        }

        public List<T> FindAll(HttpRequestBase request) 
        {
            return DbContext.FindAll<T>(request);
        }

        public List<T> FindAll(HttpRequestBase request, int top) 
        {
            return DbContext.FindAll<T>(request,top);
        }
        public PagedList<T> FindAllByPage(HttpRequestBase request, int pageSize, int pageIndex)
        {
            return DbContext.FindAllByPage<T>(request,pageSize,pageIndex);
        }
    }
}
