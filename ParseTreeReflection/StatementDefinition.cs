using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
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
