using Antlr4.Runtime;
using JavaAST.Helpers;

namespace JavaAST.PaseTreeReflection
{
    public class MethodDefinition : IDefinitionNode
    {
        public string? Name { get => _name; }
        public TypeDefinition? Result { get => _result; }
        public List<string> Modifiers { get => _modifiers; }

        public void Attach(IDefinitionNode node)
        {
        }

        public void Build(string method, ParserRuleContext context)
        {
            switch (method)
            {
                case "VisitMethodModifier":
                    _modifiers.Add(context.Start.Text);
                    break;
                case "VisitIdentifier":
                    if (_name == null)
                    {
                        _name = context.Start.Text;
                    }
                    break;
                case "VisitResult":
                    _result = TypeDefinition.GetPredefinedType(context.Start.Text);
                    break;
                default:
                    break;
            }
        }
        string? _name = null;
        TypeDefinition? _result = null;
        List<string> _modifiers = new();


    }
}
