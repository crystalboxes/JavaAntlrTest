using System.Diagnostics.CodeAnalysis;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using JavaAST.AntlrParser;
using JavaAST.Helpers;
using JavaAST.PaseTreeReflection;

namespace JavaAST.ReflectionLoader
{

    class ReflectionVisitor : ReflectionVisitorBase
    {
        public ReflectionVisitor(IDefinitionNode owner)
        {
            _depth = 0;
            _owner = owner;
        }

        public ReflectionVisitor(int depth, IDefinitionNode owner)
        {
            _depth = depth;
            _owner = owner;
        }



        int _depth = 0;
        IDefinitionNode _owner;
        static List<string> _methodsToIgnore = new()
        {
        };

        string _lastMethod = "";

        protected override void HandleIntermediateVisit(string methodName, [NotNull] ParserRuleContext context)
        {
            _lastMethod = methodName;
            if (_methodsToIgnore.Contains(methodName))
            {
                Console.WriteLine($"____Ignored {methodName}");
                return;
            }
            var space = "";
            for (int i = 0; i < _depth; i++)
            {
                space += " ";
            }

            Console.WriteLine($"{space}Visited {methodName}");
            _owner?.Build(methodName, context);
        }


        public Result VisitChildren2(IRuleNode node)
        {
            return base.VisitChildren(node);
        }


        public override Result VisitChildren(IRuleNode node)
        {
            IDefinitionNode? newOwner;

            switch (_lastMethod)
            {
                case "VisitClassDeclaration":
                    newOwner = new ClassDefinition();
                    _owner?.Attach(newOwner);
                    break;
                default:
                    newOwner = _owner;
                    break;
            }
            var childVisitor = new ReflectionVisitor(_depth + 1, newOwner);
            return childVisitor.VisitChildren2(node);
        }
    }
}