using JavaAST.PaseTreeReflection;

public class UnitDefinition : IDefinitionNode
{
    public List<ClassDefinition> Classes { get => _classes; }

    List<ClassDefinition> _classes = new();


    public void Attach(IDefinitionNode? node)
    {
        if (node == null)
        {
            return;
        }
        if (node is ClassDefinition)
        {
            Classes.Add((node as ClassDefinition)!);
        }
    }

    public void Build(string method, dynamic context)
    {
    }
}