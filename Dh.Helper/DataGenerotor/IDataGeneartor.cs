using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DHpack.DataGenerotor
{
    interface IDataGenertor
    {
        static Random Random = new Random();
        public List<string> GenerateName(int numberofNames = 1);
        public List<string> GenerateSurname(int numberOfSurnames = 1);
        public List<string> GenerateFullName(int numberOfPeople = 1);
        public List<string> GenerateEmail(int numberOfEmails = 1);
        public List<string> GenerateCountry(int numberOfCountries = 1);

        /// <summary>
        /// Get random value in Enum <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Generic Enum type</typeparam>
        /// <returns></returns>
        public static T PickRandomEnum<T>()
        {
            var output = Enum.GetValues(typeof(T));
            return (T)output.GetValue(Random.Next(output.Length));
        }

        public static IEnumerable<T> PickRandom<T>(IEnumerable<T> values)
        {
            List<T> output = new();
            return (IEnumerable<T>)output[Random.Next(output.Count)];
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
