using Antlr4.Runtime;
using JavaAST.Helpers;
using JavaAST.AntlrParser;
using JavaAST.CppCodegen;
using JavaAST.PaseTreeReflection;
using JavaAST.ReflectionLoader;
using System.Text.Json;

public static class Program
{
    public static void Main()
    {
        var text = @"class HelloWorld {
            void x() {
                int x = 1 + 1 + 5;
            }
        }";

        var lexer = new Java9Lexer(new AntlrInputStream(text));

        var parser = new Java9Parser(new CommonTokenStream(lexer));
        var tree = parser.compilationUnit();

        var def = new UnitDefinition();

        var visitor = new ReflectionVisitor(new ReflectionVisitorConfig() { ShouldLog = true }, 0);
        visitor.Owner = def;
        visitor.Visit(tree);

        var gen = new CodeGenerator(def);
        Console.WriteLine(gen.Header);
        Console.WriteLine("----------------");
        Console.WriteLine(gen.Implementation);

        string jsonString = JsonSerializer.Serialize(visitor, new JsonSerializerOptions() { MaxDepth = 256, ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve });
        File.WriteAllText("bin/out.json", jsonString);
    }
}
