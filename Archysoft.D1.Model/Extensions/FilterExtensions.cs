using System.Linq;
using Archysoft.D1.Data.Entities;
using Archysoft.D1.Model.Common;

namespace Archysoft.D1.Model.Extensions
{
    public static class FilterExtensions
    {
        public static IQueryable<User> FilterUsers(this IQueryable<User> query, BaseFilter filter)
        {
            if (!string.IsNullOrEmpty(filter.Search))
            {

            }

            return query;
        }
    }
}
