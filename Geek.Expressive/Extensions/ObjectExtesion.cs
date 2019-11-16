using System;

namespace Geek.Expressive.Extensions
{
    public static class ObjectExtesion
    {
        public static void MustNotBeNull(this object value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException($"{parameterName} mustnot be null.");
        }
    }
}
