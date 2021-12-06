using Antlr4.Runtime;
using JavaAST.Helpers;

namespace JavaAST.PaseTreeReflection
{
    public class FieldDefinition : IDefinitionNode
    {
        public string? Name { get; set; }
        public TypeDefinition? Type { get; set; }
        public ExpressionDefinition? Expression { get; }

        public void Attach(IDefinitionNode node)
        {
        }

        public void Build(string method, ParserRuleContext context)
        {
            switch (method)
            {
                case "VisitIntegralType":
                    if (Type == null)
                    {
                        Type = TypeDefinition.GetPredefinedType(context.Start.Text);
                    }
                    break;
                case "VisitIdentifier":
                    if (Name == null)
                    {
                        Name = context.Start.Text;
                    }
                    break;

                default:
                    break;
            }
        }

        ExpressionDefinition? _expression = null;
    }
}
