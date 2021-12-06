using Antlr4.Runtime;
using JavaAST.Helpers;
using JavaAST.AntlrParser;
using JavaAST.CppCodegen;

public static class Program
{
    public static void Main()
    {
        var def = TreeLoaderHelper.FromSource(@"class A {
            public static int main(String[] args) {
                // System.out.println(""Hello World!\"");
            }
        }");
        var gen = new CodeGenerator(def);

        Console.WriteLine(gen.Header);
    }
}
