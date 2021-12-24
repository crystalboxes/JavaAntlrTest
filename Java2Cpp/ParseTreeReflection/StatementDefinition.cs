using Antlr4.Runtime;
using Java2Cpp.Helpers;
using static Java2Cpp.AntlrParser.Java9Parser;

namespace Java2Cpp.PaseTreeReflection
{
    public class StatementDefinition : BaseDefinition
    {
    }
    public class LocalVariableDeclarationStatementDefinition : StatementDefinition
    {
        public TypeDefinition? Type { get; set; }
    }
    public class ReturnStatementDefinition : StatementDefinition
    {
        public ExpressionDefinition? Expression { get; set; }
    }
}
