using Antlr4.Runtime;
using Java2Cpp.Helpers;

namespace Java2Cpp.PaseTreeReflection
{
    public class ExpressionDefinition : BaseDefinition
    {
        public string? Identifier { get; set; }
        public string? Literal { get; set; }
    }
}
