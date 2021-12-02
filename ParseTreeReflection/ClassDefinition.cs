using static JavaAST.AntlrParser.Java9Parser;

namespace JavaAST.PaseTreeReflection
{
    class ClassDefinition : IDefinitionNode
    {
        public string? Name { get; set; }

        public List<ClassDefinition> ClassDefinitions { get; set; } = new();

        public void Attach(IDefinitionNode? node)
        {
        }

        public void Build(string method, dynamic context)
        {
            switch (method)
            {
                case "VisitIdentifier":
                    if (Name == null)
                    {
                        Name = (context as IdentifierContext)?.Start.Text;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
