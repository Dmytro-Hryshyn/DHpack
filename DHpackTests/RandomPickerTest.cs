using DHpack.DataGenerator.Enums;
using DHpack.DataGenerator;
using Xunit;
using System.Collections.Generic;

namespace DHpackTests
{
    public class RandomPickerTest
    {
        [Fact]
        public void PickRandomEnum_NotNull()
        {
            var actual = RandomPicker.PickRandomEnum<Gender>().ToString();
            Assert.NotNull(actual);
        }
        [Fact]
        public void PickRandomEnum_NotEmpty()
        {
            var actual = RandomPicker.PickRandomEnum<FileName>().ToString();
            Assert.NotEmpty(actual);
        }

        [Fact]
        public void PickRandom_NotEmpty()
        {
            List<string> names = new() { "Tom", "Smith", "Joy", "Bob" };
            var actual = names.PickRandom();
            Assert.NotEmpty(actual);
        }
    }
}
