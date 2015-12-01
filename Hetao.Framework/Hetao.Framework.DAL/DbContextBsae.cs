using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hetao.Framework.Contract;
using System.Web;


using Webdiyer.WebControls.Mvc;

namespace Hetao.Framework.DAL
{
    public class DbContextBsae : DbContext, IDataRepository, IDisposable
    {
        public DbContextBsae(string connectionString)
            : base(connectionString)
        {

        }

        public T Update<T>(T entity) where T : ModelBase
        {
            var set = this.Set<T>();
            set.Attach(entity);
            this.Entry<T>(entity).State = EntityState.Modified;
            this.SaveChanges();

            return entity;
        }

        public T Insert<T>(T entity) where T : ModelBase
        {
            var set = this.Set<T>();
            set.Attach(entity);
            this.Entry<T>(entity).State = EntityState.Added;
            this.SaveChanges();
            return entity;
        }

        public void Delete<T>(T entity) where T : ModelBase
        {
            this.Entry<T>(entity).State = EntityState.Deleted;
            this.SaveChanges();
        }

        public void DeleteList<T>(HttpRequestBase request) where T : ModelBase
        {
            var list = this.Set<T>().WhereIDs(request);
            this.Set<T>().RemoveRange(list);
            this.SaveChanges();
        }

        public T Find<T>(params object[] keyValues) where T : ModelBase
        {
            return this.Set<T>().Find(keyValues);
        }

        public IQueryable<T> FindAll<T>(Expression<Func<T, bool>> conditions = null) where T : ModelBase
        {
            if (conditions == null)
                return this.Set<T>();
            else
                return this.Set<T>().Where(conditions);
        }

        public IQueryable<T> FindAll<T, S>(Expression<Func<T, S>> orderBy, int top = 10) where T : ModelBase
        {
            if (orderBy == null)
                return this.Set<T>().Take(top);
            else
                return this.Set<T>().OrderByDescending(orderBy).Take(top);
        }

        public PagedList<T> FindAllByPage<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) where T : ModelBase
        {
            var queryList = conditions == null ? this.Set<T>() : this.Set<T>().Where(conditions) as IQueryable<T>;

            return queryList.OrderByDescending(orderBy).ToPagedList(pageIndex, pageSize);
        }


        public T Find<T>(HttpRequestBase request) where T : ModelBase
        {
            return this.Set<T>().Where(request).FirstOrDefault();
        }

        public List<T> FindAll<T>(HttpRequestBase request) where T : ModelBase
        {
            return this.Set<T>().Where(request).ToList();
        }

        public List<T> FindAll<T>(HttpRequestBase request,int top) where T : ModelBase
        {
            return this.Set<T>().Where(request).Order(request).Take(top).ToList();
        }
        public PagedList<T> FindAllByPage<T>(HttpRequestBase request, int pageSize, int pageIndex) where T : ModelBase
        {
            var queryList = this.Set<T>() as IQueryable<T>;

            return queryList
                 .Where(request)
                 .Order(request)
                .ToPagedList(pageIndex, pageSize);
        }
    }
}
