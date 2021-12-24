using System.Diagnostics;
using System.Drawing;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Java2Cpp.AntlrParser;
using Java2Cpp.PaseTreeReflection;
using Pastel;

namespace Java2Cpp.ReflectionLoader
{
    public struct Result
    {
    }

    public class ReflectionVisitorConfig
    {
        public bool ShouldLog { get; set; } = false;
    }

    public class ReflectionVisitorBase : Java9ParserBaseVisitor<Result>
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
            NextOwner = null;

            VisitorChildren.Add(child);

            return child.VisitChildrenBase(node);
        }


        public List<ReflectionVisitorBase> VisitorChildren { get; set; } = new();
        public string VisitorName { get; set; } = "";
        public string VisitorContextText { get; set; } = "";

        public IDefinition? Owner { get; set; } = null;
        protected int Depth { get => _depth; }
        protected virtual ReflectionVisitorBase CreateChild(ReflectionVisitorConfig config, int depth) => new ReflectionVisitorBase(config, depth);
        protected IDefinition? NextOwner { get; set; } = null;
        protected ReflectionVisitorConfig Config { get; set; }
        int _depth = 0;
    }
}
