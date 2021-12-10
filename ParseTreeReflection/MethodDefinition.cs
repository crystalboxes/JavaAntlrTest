using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public class MethodDefinition : IDefinition
    {
        public string? Name { get; set; }
        public TypeDefinition? Result { get; set; }
        public List<string> Modifiers { get; set; } = new();
    }
}
