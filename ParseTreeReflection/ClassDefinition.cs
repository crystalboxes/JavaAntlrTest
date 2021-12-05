using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public class ClassDefinition : TypeDefinition
    {

        public List<ClassDefinition> Classes { get => _classes; }
        public List<string> Modifiers { get => _modifiers; }

        public override void Attach(IDefinitionNode node)
        {
            if (node is ClassDefinition)
            {
                Classes.Add((node as ClassDefinition)!);
            }
        }

        public override void Build(string method, ParserRuleContext context)
        {
            switch (method)
            {
                case "VisitClassModifier":
                    _modifiers.Add(context.Start.Text);
                    break;
                case "VisitIdentifier":
                    if (_name == null)
                    {
                        _name = context.Start.Text;
                    }
                    break;
                default:
                    break;
            }
        }

        List<string> _modifiers = new();
        List<ClassDefinition> _classes = new();
    }
}
