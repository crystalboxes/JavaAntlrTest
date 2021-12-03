using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public class ClassDefinition : IDefinitionNode
    {

        public List<ClassDefinition> Classes { get => _classes; }
        public string? Name { get => _name; }
        public List<string> Modifiers { get => _modifiers; }

        public void Attach(IDefinitionNode node)
        {
            if (node is ClassDefinition)
            {
                Classes.Add((node as ClassDefinition)!);
            }
        }

        public void Build(string method, ParserRuleContext context)
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

        string? _name;
        List<string> _modifiers = new();
        List<ClassDefinition> _classes = new();
    }
}
