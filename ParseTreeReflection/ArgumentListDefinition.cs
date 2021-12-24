using Antlr4.Runtime;
using JavaAST.Helpers;

namespace JavaAST.PaseTreeReflection
{
    public class ArgumentListDefinition : BaseDefinition
    {
        public List<VariableDeclaratorDefinition> Entries { get; set; } = new();
    }
}
