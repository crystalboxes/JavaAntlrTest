using Xunit;
using JavaAST.Helpers;
namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var reflection = TreeLoaderHelper.FromSource("class Dog {} ");
        Assert.Equal(reflection.Classes[0].Name, "Dog");
    }
}
