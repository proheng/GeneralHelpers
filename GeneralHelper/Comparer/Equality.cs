using System.Collections.Generic;

namespace GeneralHelper.Comparer
{
    public class Equality
    {
        public static bool EqualsDefaultValue<T>(T value)
        {
            return EqualityComparer<T>.Default.Equals(value, default(T));
        }
    }
}
