using Xunit;
using System.Linq;
using System.Collections.Generic;
using DHpack.DataGenerator;
using DHpack.DataGenerator.Enums;

namespace DHpackTests
{

    public class ResourceReaderTest
    {
        [Fact]
        public void ReadFileShouldHaveValue()
        {
            List<string> name = ResourceReader.GetResourceAsLine(FileName.MaleNames.ToString()).ToList();
            Assert.NotNull(name);
        }
    }
}
