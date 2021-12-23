using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public class FieldDefinition : BaseDefinition
    {
        public string? Name { get; set; }
        public TypeDefinition? Type { get; set; }
        public List<VariableDeclaratorDefinition> VariableDeclarators { get; set; } = new();
    }
}
