using Xunit;
using JavaAST.Helpers;
using System.Collections.Generic;
using JavaAST.ReflectionLoader2;

namespace Tests
{
    public class DefinitionGenerationTests
    {
        [Fact]
        public void TestClassNames()
        {
            {
                var reflection = TreeLoaderHelper.FromSource("class Dog {} ");
                Assert.Equal("Dog", reflection.Classes[0].Name);
            }
            {
                var reflection = TreeLoaderHelper.FromSource(@"
                class Dog {} 
                class Cat {}
                class Pillow {}
                ");
                Assert.Equal("Dog", reflection.Classes[0].Name);
                Assert.Equal("Cat", reflection.Classes[1].Name);
                Assert.Equal("Pillow", reflection.Classes[2].Name);
            }
        }

        [Fact]
        public void TestClassModifiers()
        {
            {
                var reflection = TreeLoaderHelper.FromSource("public class Dog {} ");
                Assert.Single(reflection.Classes[0].Modifiers);
                Assert.Equal("public", reflection.Classes[0].Modifiers[0]);
            }
            {
                var reflection = TreeLoaderHelper.FromSource("public static class Dog {} ");
                Assert.Equal(new List<string>() { "public", "static" }, reflection.Classes[0].Modifiers);
            }
        }


        [Fact]
        public void TestNestedClasses()
        {
            var reflection = TreeLoaderHelper.FromSource(@"class A {
                static class B {}
            } ");
            Assert.Single(reflection.Classes[0].Classes);
            Assert.Equal("B", reflection.Classes[0].Classes[0].Name);
            Assert.Equal("static", reflection.Classes[0].Classes[0].Modifiers[0]);
        }

        [Fact]
        public void TestTypeExtraction()
        {
            var reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                public static void main(String[] args) {
                }
            }");
            Assert.Single(reflection.Classes[0].Methods);
        }
    }
}
