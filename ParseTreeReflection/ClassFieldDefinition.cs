using Antlr4.Runtime;
using JavaAST.Helpers;

namespace JavaAST.PaseTreeReflection
{
    class ClassFieldDefinition : IDefinitionNode
    {
        public string? Name { get; set; }
        public string? TypeName { get; set; }

        public void Attach(IDefinitionNode node)
        {
            throw new NotImplementedException();
        }

        public void Build(string method, ParserRuleContext context)
        {
            throw new NotImplementedException();
        }
    }
}
