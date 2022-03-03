using FirstApi.Domain.Commons.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Extentions
{
    public static class LinqExtentions
    {
        public static IQueryable<T> Whereif<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool> >predcate)
        {
            if (condition)
            {
                query = query.Where(predcate);
            }
            return query;
        }
        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, IRequestPaging request) {
            return query.Skip((request.CurrentPage-1)*request.Limit).Take(request.Limit);
        }
    }
}
