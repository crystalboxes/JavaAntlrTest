using Antlr4.Runtime;
using JavaAST.Helpers;

namespace JavaAST.PaseTreeReflection
{
    public interface IDefinitionNode
    {
        void Attach(IDefinitionNode node);
        void Build(string method, ParserRuleContext context);
    }
}
