using System.Diagnostics;
using System.Drawing;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Java2Cpp.AntlrParser;
using Pastel;

namespace Java2Cpp.ReflectionLoader
{
    public class ReflectionVisitorLogged : ReflectionVisitorBase
    {
        public ReflectionVisitorLogged(ReflectionVisitorConfig config, int depth) : base(config, depth)
        {
        }
        protected override ReflectionVisitorBase CreateChild(ReflectionVisitorConfig config, int depth) => new ReflectionVisitorLogged(config, depth);

        public override Result VisitChildren(IRuleNode node)
        {
            if (Config.ShouldLog)
            {
                LogCall(node);
            }


            return base.VisitChildren(node);
        }


        void LogCall(IRuleNode node)
        {
            var st = new StackTrace(new StackFrame(2));
            var methodName = st.GetFrame(0)?.GetMethod()?.Name ?? "Unknown";
            var contextText = (node as ParserRuleContext)?.Start.Text ?? "..";

            VisitorName = ProcessMethodName(methodName);
            VisitorContextText = contextText;

            var depth = Depth;
            PrettyPrintLog(depth, methodName, contextText);
        }

        static void PrettyPrintLog(int depth, string methodName, string contextText)
        {
            var space = "";
            for (int i = 0; i < depth; i++)
            {
                space += ".".Pastel("525252");
            }
            Console.WriteLine($"{space}{ProcessMethodName(methodName.Replace("Visit", "")).Pastel(Color.Turquoise)} {$"({methodName})".Pastel(Color.Gray)}: {contextText.Pastel(Color.Orange)}");

        }

        static string ProcessMethodName(string methodName)
        {
            var result = methodName.SelectMany((c, i) => i != 0 && char.IsUpper(c) && !char.IsUpper(methodName[i - 1]) ? new char[] { ' ', c } : new char[] { c });
            var processedMethodName = new String(result.ToArray());
            return processedMethodName;
        }
    }
}