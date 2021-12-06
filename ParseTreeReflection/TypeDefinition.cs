
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


        public string? Name { get => _name; }

        public virtual void Attach(IDefinitionNode node)
        {
        }

        public virtual void Build(string method, ParserRuleContext context)
        {
        }

        public static TypeDefinition? GetPredefinedType(string name)
        {
            return Types.GetValueOrDefault(name);
        }

        protected string? _name;

        static Dictionary<string, TypeDefinition> Types = new()
        {
            { "int", new TypeDefinition("int") },
            { "void", new TypeDefinition("void") },
        };
    }

}

