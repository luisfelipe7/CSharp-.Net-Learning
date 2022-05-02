using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThirdApplication.Entity
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<System.Collections.Generic.List<T>> InSetsOf<T>(this System.Collections.Generic.IEnumerable<T> source, int max)
        {
            List<T> toReturn = new List<T>(max);
            foreach (var item in source)
            {
                toReturn.Add(item);
                if (toReturn.Count == max)
                {
                    yield return toReturn;
                    toReturn = new List<T>(max);
                }
            }
            if (toReturn.Any())
            {
                yield return toReturn;
            }
        }
    }
}

