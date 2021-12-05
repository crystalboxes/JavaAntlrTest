
using Antlr4.Runtime;

namespace JavaAST.PaseTreeReflection
{
    public class TypeDefinition : IDefinitionNode
    {
        public TypeDefinition()
        {
        }
        public TypeDefinition(string name)
        {
            _name = name;
        }

        public static Dictionary<string, TypeDefinition> Types = new()
        {
            { "int", new TypeDefinition("int") },
        };

        public string? Name { get => _name; }

        public virtual void Attach(IDefinitionNode node)
        {
        }

        public virtual void Build(string method, ParserRuleContext context)
        {
        }

        protected string? _name;
    }

}

