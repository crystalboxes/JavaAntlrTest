using Antlr4.Runtime;
using Java2Cpp.Helpers;
using static Java2Cpp.AntlrParser.Java9Parser;

namespace Java2Cpp.PaseTreeReflection
{
    public interface IDefinition
    {
        IDefinition? Parent { get; set; }
    }
}