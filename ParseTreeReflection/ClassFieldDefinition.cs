namespace JavaAST.PaseTreeReflection
{
    class ClassFieldDefinition : IDefinitionNode
    {
        public string? Name { get; set; }
        public string? TypeName { get; set; }

        public void Attach(IDefinitionNode? node)
        {
            throw new NotImplementedException();
        }

        public void Build(string method, dynamic context)
        {
            throw new NotImplementedException();
        }
    }
}
