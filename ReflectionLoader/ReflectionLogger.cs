using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using JavaAST.AntlrParser;
using JavaAST.Helpers;
using JavaAST.PaseTreeReflection;
using Pastel;

namespace JavaAST.ReflectionLoader
{
    class ReflectionLogger
    {
        private ReflectionVisitor _visitor;

        public ReflectionLogger(ReflectionVisitor visitor)
        {
            _visitor = visitor;
        }

        internal void Log(string methodName, ParserRuleContext context)
        {
            if (_methodsToIgnore.Contains(methodName))
            {
                Console.WriteLine($"____Ignored {methodName}");
                return;
            }
            var space = "";
            for (int i = 0; i < _visitor.Depth; i++)
            {
                space += ".".Pastel("525252");
            }

            Console.WriteLine($"{space}{ProcessMethodName(methodName.Replace("Visit", "")).Pastel(Color.Turquoise)} {$"({methodName})".Pastel(Color.Gray)}: {context.Start.Text.Pastel(Color.Orange)}");
        }

        string ProcessMethodName(string methodName)
        {
            var result = methodName.SelectMany((c, i) => i != 0 && char.IsUpper(c) && !char.IsUpper(methodName[i - 1]) ? new char[] { ' ', c } : new char[] { c });
            return new String(result.ToArray());
        }

        static List<string> _methodsToIgnore = new()
        {
        };
    }
}