using Antlr4.Runtime;


public static class Program
{
    public static void Main()
    {
        var text = File.ReadAllText("HelloWorld.java");
        var lexer = new Java9Lexer(new AntlrInputStream(text));



        var parser = new Java9Parser(new CommonTokenStream(lexer));
        var tree = parser.compilationUnit();

        var visitor = new JavaVisitor();
        visitor.Visit(tree);

        
        Console.WriteLine("heloo world ");
    }
}
