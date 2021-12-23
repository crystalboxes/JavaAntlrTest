using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public class BaseDefinition : IDefinition
    {
        public IDefinition? Parent { get; set; } = null;
    }
}