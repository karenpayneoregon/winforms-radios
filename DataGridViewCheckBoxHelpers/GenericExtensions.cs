using System;

namespace DataGridViewCheckBoxHelpers
{
    public static class GenericExtensions
    {
        public static T ToEnum<T>(this int pValue)
        {
            return (T)Enum.Parse(typeof(T), pValue.ToString());
        }
    }
}
