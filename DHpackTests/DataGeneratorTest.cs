using Xunit;
using System.Linq;
using System.Collections.Generic;
using DHpack.DataGenerator;
using DHpack.DataGenerator.Enums;

namespace DHpackTests
{

    public class DataGeneratorTest
    {
        [Fact]
        public void ReadFileShouldHaveValue()
        {
            List<string> name = IDataGenerator.GetResourceAsLine(FileName.MaleNames.ToString()).ToList();
            Assert.NotNull(name);
        }

        [Fact]
        public void GenerateRandomEnum_NotNull()
        {
            var actual = IDataGenerator.PickRandomEnum<Gender>().ToString();
            Assert.NotNull(actual);
        }
    }
}
