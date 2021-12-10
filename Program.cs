using Antlr4.Runtime;
using JavaAST.Helpers;
using JavaAST.AntlrParser;
using JavaAST.CppCodegen;
using JavaAST.PaseTreeReflection;
using JavaAST.ReflectionLoader;

public static class Program
{
    public static void Main()
    {
        var text = @"public static class A {
            public static int main(String[] args) {
                // System.out.println(""Hello World!\"");
            }
        }";


        var lexer = new Java9Lexer(new AntlrInputStream(text));

        var parser = new Java9Parser(new CommonTokenStream(lexer));
        var tree = parser.compilationUnit();

        var def = new UnitDefinition();
        var visitor = new ReflectionVisitor(new ReflectionVisitorConfig() { ShouldLog = true }, 0);
        visitor.Owner = def;
        visitor.Visit(tree);
        // var def = TreeLoaderHelper.FromSource(source);
        var gen = new CodeGenerator(def);

        Console.WriteLine(gen.Header);
    }
}
