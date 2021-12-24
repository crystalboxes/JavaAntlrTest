using Antlr4.Runtime;
using JavaAST.Helpers;

namespace JavaAST.PaseTreeReflection
{
    public class ExpressionDefinition : BaseDefinition
    {
        public string? Identifier { get; set; }
        public string? Literal { get; set; }
    }
}
