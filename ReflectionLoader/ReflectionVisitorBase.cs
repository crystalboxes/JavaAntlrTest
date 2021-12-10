using System.Diagnostics;
using System.Drawing;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using JavaAST.AntlrParser;
using JavaAST.PaseTreeReflection;
using Pastel;

namespace JavaAST.ReflectionLoader
{
    struct Result
    {
    }

    public class ReflectionVisitorConfig
    {
        public bool ShouldLog { get; set; } = false;
    }

    class ReflectionVisitorBase : Java9ParserBaseVisitor<Result>
    {
        public ReflectionVisitorBase(ReflectionVisitorConfig config, int depth)
        {
            _depth = depth;
            Config = config;
        }
        public Result VisitChildrenBase(IRuleNode node) => base.VisitChildren(node);
        public override Result VisitChildren(IRuleNode node)
        {
            var child = CreateChild(Config, _depth + 1);
            child.Owner = NextOwner ?? Owner;
            return child.VisitChildrenBase(node);
        }
        public IDefinition? Owner { get; set; } = null;
        protected int Depth { get => _depth; }
        protected virtual ReflectionVisitorBase CreateChild(ReflectionVisitorConfig config, int depth) => new ReflectionVisitorBase(config, depth);
        protected IDefinition? NextOwner { get; set; } = null;
        protected ReflectionVisitorConfig Config { get; set; }
        int _depth = 0;
    }
}
