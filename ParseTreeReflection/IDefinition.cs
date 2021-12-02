namespace JavaAST.PaseTreeReflection
{
    public interface IDefinitionNode
    {
        void Attach(IDefinitionNode? node);
        void Build(string method, dynamic context);
    }
}
