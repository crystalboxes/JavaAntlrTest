using Antlr4.Runtime;
using JavaAST.Helpers;
using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    public class ClassDefinition : TypeDefinition
    {
        public List<ClassDefinition> Classes { get => _classes; }
        public List<string> Modifiers { get => _modifiers; }
        public List<FieldDefinition> Fields { get => _fields; }
        public List<MethodDefinition> Methods { get => _methods; }

        public override void Attach(IDefinitionNode node)
        {
            if (node is ClassDefinition)
            {
                Classes.Add((node as ClassDefinition)!);
            }
            else if (node is FieldDefinition)
            {
                Fields.Add((node as FieldDefinition)!);
            }
            else if (node is MethodDefinition)
            {
                Methods.Add((node as MethodDefinition)!);
            }
            else
            {
                throw new NotImplementedException();
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
        List<FieldDefinition> _fields = new();
        List<MethodDefinition> _methods = new();
    }
}
