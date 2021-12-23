using Antlr4.Runtime;
using JavaAST.Helpers;
namespace JavaAST.PaseTreeReflection
{
    public class UnitDefinition : BaseDefinition
    {
        public List<ClassDefinition> Classes { get; set; } = new();
    }
}