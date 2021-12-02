namespace JavaAST.PaseTreeReflection
{
    class ClassDefinition : IDefinitionNode
    {
        public ClassDefinition(string name)
        {
            Name = name;
        }
        public string? Name { get; set; }

        public List<ClassDefinition> ClassDefinitions { get; set; } = new();

        public void Attach(IDefinitionNode node)
        {
            throw new NotImplementedException();
        }

        public void ReadParseData(string methodName, dynamic context)
        {
            throw new NotImplementedException();
        }
    }
}
