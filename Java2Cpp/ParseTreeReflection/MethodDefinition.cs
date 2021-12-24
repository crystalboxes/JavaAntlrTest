using Antlr4.Runtime;
using Java2Cpp.Helpers;
using static Java2Cpp.AntlrParser.Java9Parser;

namespace Java2Cpp.PaseTreeReflection
{
    public class MethodDefinition : BaseDefinition
    {
        public string? Name { get; set; }
        public TypeDefinition? Result { get; set; }
        public List<string> Modifiers { get; set; } = new();

        public ArgumentListDefinition Arguments { get; set; } = new();

        public StatementsBlockDefinition? Statements { get; set; }
    }
}
