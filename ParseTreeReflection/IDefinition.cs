using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public interface IDefinition
    {
        IDefinition? Parent { get; set; }
    }
}