using Antlr4.Runtime;
using Java2Cpp.Helpers;
using static Java2Cpp.AntlrParser.Java9Parser;

namespace Java2Cpp.PaseTreeReflection
{
    public class FieldDefinition : BaseDefinition
    {
        public string? Name { get; set; }
        public TypeDefinition? Type { get; set; }
        public List<VariableDeclaratorDefinition> VariableDeclarators { get; set; } = new();
    }
}
