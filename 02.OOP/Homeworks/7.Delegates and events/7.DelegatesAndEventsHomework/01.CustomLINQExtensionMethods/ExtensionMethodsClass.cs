using System;
using System.Collections.Generic;

namespace _01.CustomLINQExtensionMethods
{
    public static class ExtensionMethodsClass
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            ICollection<T> resultCollection = new List<T>();

            foreach (var item in collection)
            {
                if (!condition(item))
                {
                    resultCollection.Add(item);
                }
            }

            return resultCollection;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collecion,
            Func<TSource, TSelector> delegatFunc) where TSelector : IComparable<TSelector>
        {
            TSelector max = default(TSelector);
            foreach (var item in collecion)
            {
                TSelector currentSelector = delegatFunc(item);
                if (currentSelector.CompareTo(max) > 0)
                {
                    max = currentSelector;
                }
            }

            return max;
        }
    }
}
