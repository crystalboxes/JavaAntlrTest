using Antlr4.Runtime;
using JavaAST.Helpers;
using JavaAST.AntlrParser;
using JavaAST.CppCodegen;

public static class Program
{
    public static void Main()
    {
        // var def = TreeLoaderHelper.FromFile("Tests/HelloWorld.java");
        var def = TreeLoaderHelper.FromSource(@"class A {
            int x = (1 + 2) * 3;
        }");
        var gen = new CodeGenerator(def);

        Console.WriteLine("heloo world ");
        Console.WriteLine(gen.Header);
    }
}
