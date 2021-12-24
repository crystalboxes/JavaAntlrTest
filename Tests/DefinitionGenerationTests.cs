using Xunit;
using JavaAST.Helpers;
using System.Collections.Generic;
using JavaAST.ReflectionLoader;
using JavaAST.PaseTreeReflection;

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
        public void TestMethodTypeExtraction()
        {
            var reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                public static void main(String[] args) {
                }
            }");

            Assert.Equal("main", reflection.Classes[0].Methods[0].Name);

            Assert.Single(reflection.Classes[0].Methods);
            Assert.Equal("void", reflection.Classes[0].Methods[0].Result?.Name);
        }
        [Fact]
        public void TestIntegralMethodTypeExtraction()
        {
            UnitDefinition reflection;

            reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                public static int[] main() {
                }
            }");
            Assert.Equal("int[]", reflection.Classes[0].Methods[0].Result?.Name);
            Assert.True(reflection.Classes[0].Methods[0].Result?.IsArrayType);
            Assert.Equal("int", reflection.Classes[0].Methods[0].Result?.IntegralTypeName);

            reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                    public static String main() {
                    }
                }");
            Assert.True(reflection.Classes[0].Methods[0].Result?.IsInterfaceType);
        }

        [Fact]
        public void TestFieldTypeExtraction()
        {
            UnitDefinition reflection;

            reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                int[] x;
            }");
            Assert.Equal("int[]", reflection.Classes[0].Fields[0].Type?.Name);
            Assert.True(reflection.Classes[0].Fields[0].Type?.IsArrayType);
            Assert.Equal("int", reflection.Classes[0].Fields[0].Type?.IntegralTypeName);
        }

        [Fact]
        public void TestVariableDeclarators()
        {
            UnitDefinition reflection;

            reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                int[] x,y,z;
                String l;
            }");
            Assert.Equal("x", reflection.Classes[0].Fields[0].VariableDeclarators[0].Name);
            Assert.Equal("y", reflection.Classes[0].Fields[0].VariableDeclarators[1].Name);
            Assert.Equal("z", reflection.Classes[0].Fields[0].VariableDeclarators[2].Name);

            Assert.Equal("l", reflection.Classes[0].Fields[1].VariableDeclarators[0].Name);
            Assert.Equal("String", reflection.Classes[0].Fields[1].Type!.Name);
        }
        [Fact]
        public void TestMethodArgumentsTypeExtraction()
        {
            UnitDefinition reflection;

            reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                void x(int a, String b, double c = 2.0) {}
            }");
            Assert.Equal("int", reflection.Classes[0].Methods[0].Arguments.Entries[0].Type!.Name);
            Assert.Equal("String", reflection.Classes[0].Methods[0].Arguments.Entries[1].Type!.Name);
            Assert.Equal("double", reflection.Classes[0].Methods[0].Arguments.Entries[2].Type!.Name);
        }
        [Fact]
        public void TestMethodArgumentsNameExtraction()
        {
            UnitDefinition reflection;

            reflection = TreeLoaderHelper.FromSource(@"class HelloWorld {
                void x(int a, String b, double c = 2.0) {}
            }");
            Assert.Equal("a", reflection.Classes[0].Methods[0].Arguments.Entries[0].Name);
            Assert.Equal("b", reflection.Classes[0].Methods[0].Arguments.Entries[1].Name);
            Assert.Equal("c", reflection.Classes[0].Methods[0].Arguments.Entries[2].Name);
        }
    }
}
