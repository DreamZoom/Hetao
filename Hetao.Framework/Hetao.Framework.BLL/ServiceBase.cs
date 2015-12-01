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

        public virtual T Update(T entity)
        {
            return  DbContext.Update(entity);
        }

        public virtual T Insert(T entity) 
        {
            return DbContext.Insert(entity);
        }

        public virtual void Delete(T entity) 
        {
             DbContext.Delete(entity);
        }

        public virtual void DeleteList(HttpRequestBase request)
        {
            //DbContext.DeleteList<T>(request);
            var list = DbContext.Set<T>().WhereIDs(request);
            DbContext.Set<T>().RemoveRange(list);
            DbContext.SaveChanges();
        }

        public virtual T Find(params object[] keyValues) 
        {
            return DbContext.Find<T>(keyValues);
        }

        public virtual IQueryable<T> FindAll(Expression<Func<T, bool>> conditions = null)
        {
            return DbContext.FindAll<T>(conditions);
        }

        public virtual IQueryable<T> FindAll<S>(Expression<Func<T, S>> orderBy, int top = 10)
        {
            return DbContext.FindAll<T,S>(orderBy, top);
        }

        public virtual PagedList<T> FindAllByPage<S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) 
        {
            return DbContext.FindAllByPage<T, S>(conditions, orderBy, pageSize, pageIndex);
        }


        public virtual T Find(HttpRequestBase request) 
        {
            return DbContext.Find<T>(request);
        }

        public virtual List<T> FindAll(HttpRequestBase request) 
        {
            return DbContext.FindAll<T>(request);
        }

        public virtual List<T> FindAllWithIDs(HttpRequestBase request)
        {
            var list = DbContext.Set<T>().WhereIDs(request);
            return list.ToList();
        }

        public virtual List<T> FindAll(HttpRequestBase request, int top) 
        {
            return DbContext.FindAll<T>(request,top);
        }
        public virtual PagedList<T> FindAllByPage(HttpRequestBase request, int pageSize, int pageIndex)
        {
            return DbContext.FindAllByPage<T>(request,pageSize,pageIndex);
        }
    }
}
