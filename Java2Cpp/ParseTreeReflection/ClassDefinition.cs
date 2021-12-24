

namespace Java2Cpp.PaseTreeReflection
{
    public class ClassDefinition : BaseDefinition
    {
        public string? Name { get; set; }
        public List<string> Modifiers { get; set; } = new();
        public List<FieldDefinition> Fields { get; set; } = new();
        public List<MethodDefinition> Methods { get; set; } = new();
        public List<ClassDefinition> Classes { get; set; } = new();
    }
}