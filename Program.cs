using Antlr4.Runtime;
using JavaAST.Helpers;
using JavaAST.AntlrParser;

public static class Program
{
    public static void Main()
    {
        var def = TreeLoaderHelper.FromFile("Tests/HelloWorld.java");

        Console.WriteLine("heloo world ");
    }
}
