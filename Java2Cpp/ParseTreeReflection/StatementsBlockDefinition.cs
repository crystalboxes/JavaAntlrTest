using Antlr4.Runtime;
using Java2Cpp.Helpers;

namespace Java2Cpp.PaseTreeReflection
{
    public class StatementsBlockDefinition : BaseDefinition
    {
        public List<StatementDefinition> Entries { get; set; } = new();
    }
}
