using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geek.Expressive.Extensions
{
    public static class LinqExtension
    {

        public static IEnumerable<T> SafeWhere<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            if (collection == null)
                return Enumerable.Empty<T>();

            return collection.Where(predicate);
        }
        public static bool SafeAny<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return false;

            return collection.Any();
        }

        public static bool SafeAny<T>(this IEnumerable<T> collection, Func<T,bool> predicate)
        {
            if (collection == null)
                return false;

            return collection.Any(predicate);
        }

        public static List<T> ToSafeList<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return new List<T>();

            return collection.ToList();
        }
    }
}
