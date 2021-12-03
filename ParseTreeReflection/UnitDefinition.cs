using Antlr4.Runtime;
using JavaAST.Helpers;
namespace JavaAST.PaseTreeReflection
{


    public class UnitDefinition : IDefinitionNode
    {
        public List<ClassDefinition> Classes { get => _classes; }

        List<ClassDefinition> _classes = new();


        public void Attach(IDefinitionNode node)
        {

            if (node is ClassDefinition)
            {
                Classes.Add((node as ClassDefinition)!);
            }
        }

        public void Build(string method, ParserRuleContext context)
        {
        }
    }
}