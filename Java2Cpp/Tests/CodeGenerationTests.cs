using Xunit;
using Java2Cpp.Helpers;
using System.Collections.Generic;
using Java2Cpp.CppCodegen;

namespace Tests
{
    public class CodeGenerationTests
    {
        [Fact]
        public void TestPragmaOnce()
        {
            var stream = new SourceBuilder();
            stream.AddPragmaOnce();
            Assert.Equal("#pragma once\n", stream.ToString());
        }
    }
}
