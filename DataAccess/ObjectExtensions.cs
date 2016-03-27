using System;

namespace DataAccess
{
    public static class ObjectExtensions
    {
        public static int ToInt(this object o)
        {
            int value;
            var result = int.TryParse(o.ToString(), out value);

            if (!result)
            {
                return (int) double.Parse(o.ToString());
            }

            return value;
        }

        public static DateTime ToDate(this object o)
        {
            return DateTime.Parse(o.ToString());
        }

        public static bool ToBool(this object o)
        {
            return bool.Parse(o.ToString());
        }
    }
}