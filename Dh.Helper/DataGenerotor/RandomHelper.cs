using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DHpack.DataGenerotor
{
    public static class RandomHelper
    {
        public static Random random { get; set; } = new Random();
        public static IEnumerable<T> PickRandom<T>(IEnumerable<T> values)
        {
            List<T> output = new();
            return (IEnumerable<T>)output[random.Next(output.Count)];
        }
        public static T PickRandomEnum<T>()
        {
            var output = Enum.GetValues(typeof(T));
            return (T)output.GetValue(random.Next(output.Length));
        }
        public static Stream GetResourceAsStream(string resourceName)
        {
            return typeof(IDataGenertor).GetTypeInfo().Assembly.GetManifestResourceStream($"DHpack.DataGenerator.Data.{resourceName}.txt");
        }
        public static IEnumerable<string> GetResourceAsLine(string fileName)
        {
            var stream = GetResourceAsStream(fileName);
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
