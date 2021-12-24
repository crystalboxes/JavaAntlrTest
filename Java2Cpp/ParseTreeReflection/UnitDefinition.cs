using Antlr4.Runtime;
using Java2Cpp.Helpers;
namespace Java2Cpp.PaseTreeReflection
{
    public class UnitDefinition : BaseDefinition
    {
        public List<ClassDefinition> Classes { get; set; } = new();
    }
}