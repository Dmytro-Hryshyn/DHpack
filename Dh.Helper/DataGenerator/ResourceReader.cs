using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DHpack.DataGenerator
{
    public static class ResourceReader
    {
        internal static Stream GetResourceAsStream(string resourceName)
        {
            return typeof(IDataGenerator).GetTypeInfo().Assembly.GetManifestResourceStream($"DHpack.DataGenerator.Data.{resourceName}.txt");
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
