using Xunit;
using JavaAST.Helpers;
using System.Collections.Generic;
using JavaAST.CppCodegen;

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
