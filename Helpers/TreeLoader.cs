using Antlr4.Runtime;
using JavaAST.AntlrParser;
using JavaAST.PaseTreeReflection2;
using JavaAST.ReflectionLoader2;

namespace JavaAST.Helpers
{
    public static class TreeLoaderHelper
    {

        public static UnitDefinition FromFile(string filename)
        {
            var text = File.ReadAllText(filename);
            return TreeLoaderHelper.FromSource(text);
        }
        public static UnitDefinition FromSource(string text)
        {
            var lexer = new Java9Lexer(new AntlrInputStream(text));

            var parser = new Java9Parser(new CommonTokenStream(lexer));
            var tree = parser.compilationUnit();

            var def = new UnitDefinition();
            var visitor = new ReflectionVisitor(new ReflectionVisitorConfig(), 0);
            visitor.Owner = def;
            visitor.Visit(tree);
            return def;
        }

    }
}