using System.Diagnostics.CodeAnalysis;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using JavaAST.PaseTreeReflection;

namespace JavaAST.ReflectionLoader
{
    class ReflectionVisitor : ReflectionVisitorBase
    {
        public ReflectionVisitor(IDefinitionNode owner)
        {
            _depth = 0;
            _owner = owner;
            _logger = new ReflectionLogger(this);
        }

        public ReflectionVisitor(int depth, IDefinitionNode owner)
        {
            _depth = depth;
            _owner = owner;
            _logger = new ReflectionLogger(this);
        }

        public int Depth { get { return _depth; } }

        public override Result VisitChildren(IRuleNode node)
        {
            IDefinitionNode newOwner;

            switch (_lastMethod)
            {
                case "VisitClassDeclaration":
                    newOwner = new ClassDefinition();
                    _owner.Attach(newOwner);
                    break;
                case "VisitFieldDeclaration":
                    newOwner = new FieldDefinition();
                    _owner.Attach(newOwner);
                    break;
                case "VisitExpression":
                    newOwner = new ExpressionDefinition();
                    _owner.Attach(newOwner);
                    break;
                case "VisitMethodDeclaration":
                    newOwner = new MethodDefinition();
                    _owner.Attach(newOwner);
                    break;
                case "VisitResult":
                    newOwner = new TypeDefinition();
                    _owner.Attach(newOwner);
                    break;
                default:
                    newOwner = _owner;
                    break;
            }
            var childVisitor = new ReflectionVisitor(_depth + 1, newOwner);
            return childVisitor.VisitChildrenBase(node);
        }

        public Result VisitChildrenBase(IRuleNode node)
        {
            return base.VisitChildren(node);
        }

        protected override void HandleIntermediateVisit(string methodName, [NotNull] ParserRuleContext context)
        {
            _lastMethod = methodName;
            _logger.Log(methodName, context);
            _owner.Build(methodName, context);
        }

        string _lastMethod = "";
        int _depth = 0;
        IDefinitionNode _owner;
        ReflectionLogger _logger;
    }
}
