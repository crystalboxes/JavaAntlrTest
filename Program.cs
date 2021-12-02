using Antlr4.Runtime;
using JavaAST.AntlrParser;
using JavaAST.ReflectionVisitor;

public static class Program
{
    public static void Main()
    {
        var text = File.ReadAllText("HelloWorld.java");
        var lexer = new Java9Lexer(new AntlrInputStream(text));



        var parser = new Java9Parser(new CommonTokenStream(lexer));
        var tree = parser.compilationUnit();

        var visitor = new ReflectionVisitor();
        visitor.Visit(tree);


        Console.WriteLine("heloo world ");
    }
}
