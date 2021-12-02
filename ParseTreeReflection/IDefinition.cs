namespace JavaAST.PaseTreeReflection
{
    public interface IDefinitionNode
    {
        void Attach(IDefinitionNode node);
        void ReadParseData(string methodName, dynamic context);
    }
}
