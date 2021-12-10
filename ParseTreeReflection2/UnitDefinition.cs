using Antlr4.Runtime;
using JavaAST.Helpers;
namespace JavaAST.PaseTreeReflection2
{
    public class UnitDefinition : IDefinition
    {
        public List<ClassDefinition> Classes { get; set; } = new();
    }
}