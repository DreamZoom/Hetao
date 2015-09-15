using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Hetao.Framework.Contract
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, HttpRequestBase request)
        {

            ParameterExpression exp_T = Expression.Parameter(typeof(TSource), "TSource"); //参数a
            var propertys = typeof(TSource).GetProperties();

            Expression where = Expression.Constant(true);
            foreach (var p in propertys)
            {
                string v = request.Params[p.Name];
                if (string.IsNullOrWhiteSpace(v)) continue;

                MemberExpression member = Expression.Property(exp_T, p);
                Expression valueExpression = Expression.Convert(Expression.Constant(v), p.PropertyType);
                var exps = Expression.Equal(member, valueExpression);

                where = Expression.And(where, exps);
            }

            Expression<Func<TSource, bool>> wherefunc = null;

            wherefunc = Expression.Lambda<Func<TSource, bool>>(where, exp_T);


            return source.Where(wherefunc);

        }

        public static IQueryable<TSource> Order<TSource>(this IQueryable<TSource> source, HttpRequestBase request)
        {

            ParameterExpression exp_T = Expression.Parameter(typeof(TSource), "TSource"); //参数a
            var propertys = typeof(TSource).GetProperties();

            Expression where = Expression.Constant(true);
            foreach (var p in propertys)
            {
                string key ="order_"+ p.Name;
                string v = request.Params[key];
                if (string.IsNullOrWhiteSpace(v)) continue;

                source = source.SortBy<TSource>(v);//多字段排序      
            }

           
            return source;

        }

        /// <summary>
        /// 根据名称排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="sortExpression"></param>
        /// <returns></returns>
        public static IQueryable<T> SortBy<T>(this IQueryable<T> source, string sortExpression)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            string sortDirection = String.Empty;
            string propertyName = String.Empty;

            sortExpression = sortExpression.Trim();
            int spaceIndex = sortExpression.Trim().IndexOf(" ");
            if (spaceIndex < 0)
            {
                propertyName = sortExpression;
                sortDirection = "ASC";
            }
            else
            {
                propertyName = sortExpression.Substring(0, spaceIndex);
                sortDirection = sortExpression.Substring(spaceIndex + 1).Trim().ToUpper();
            }

            if (String.IsNullOrEmpty(propertyName))
            {
                return source;
            }

            ParameterExpression parameter = Expression.Parameter(source.ElementType, String.Empty);
            MemberExpression property = Expression.Property(parameter, propertyName);
            LambdaExpression lambda = Expression.Lambda(property, parameter);

            string methodName = (sortDirection == "ASC") ? "OrderBy" : "OrderByDescending";

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                                new Type[] { source.ElementType, property.Type },
                                                source.Expression, Expression.Quote(lambda));

            return source.Provider.CreateQuery<T>(methodCallExpression);
        }
  

    }
}
