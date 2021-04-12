using System;
using System.Collections.Generic;
using System.Linq;

namespace DHpack.DataGenerator
{
    public static class RandomPicker
    {
        private static Random Random = new();

        /// <summary>
        /// Pick random value in <typeparamref name="T"/> enumeration type
        /// </summary>
        /// <typeparam name="T">Enum collection</typeparam>
        /// <returns>Random value from <typeparamref name="T"/> enumaration type</returns>
        public static T PickRandomEnum<T>()
        {
            var output = Enum.GetValues(typeof(T));
            return (T)output.GetValue(Random.Next(output.Length));
        }

        /// <summary>
        /// Pick random values in <typeparamref name="T"/> collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns>element of type <typeparamref name="T"/></returns>

        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            var output = source.ToArray();
            return output[Random.Next(output.Length)];
            
        }
    }
}
