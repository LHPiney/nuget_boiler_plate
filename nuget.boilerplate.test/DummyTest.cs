using nuget_boiler_plate;

namespace nuget.boilerplate.test;

public class DummyTest
{
    [Fact]
    public void Test1()
    {
        var class1 = new Class1();

        Assert.NotNull(class1);
    }
    
    [Fact]
    public void Test2()
    {
        var class2 = new Class2();

        Assert.NotNull(class2);
    }
}