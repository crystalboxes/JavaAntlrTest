

namespace Java2Cpp.PaseTreeReflection
{
    public class VariableDeclaratorDefinition : BaseDefinition
    {
        public string? Name { get; set; }
        public ExpressionDefinition? Expression { get; set; }
        public TypeDefinition? Type { get; set; }
    }
}
