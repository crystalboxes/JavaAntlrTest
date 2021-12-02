using JavaAST.PaseTreeReflection;

public class UnitDefinition : IDefinitionNode
{

    List<ClassDefinition> _classes = new();
    public void Attach(IDefinitionNode? node)
    {
        if (node == null) {
            return;
        }
        if (node is ClassDefinition)
        {
            _classes.Add((node as ClassDefinition)!);
        }
    }

    public void Build(string method, dynamic context)
    {
    }
}