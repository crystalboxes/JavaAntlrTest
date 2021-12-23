

namespace JavaAST.PaseTreeReflection
{
    public class TypeDefinition : BaseDefinition
    {
        public string? Name { get; set; }
        public string? IntegralTypeName { get; set; }
        public bool IsArrayType { get; set; } = false;
        public bool IsInterfaceType { get; set; } = false;
    }
}
