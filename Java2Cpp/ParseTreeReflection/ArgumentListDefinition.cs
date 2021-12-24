using Antlr4.Runtime;
using Java2Cpp.Helpers;

namespace Java2Cpp.PaseTreeReflection
{
    public class ArgumentListDefinition : BaseDefinition
    {
        public List<VariableDeclaratorDefinition> Entries { get; set; } = new();
    }
}
