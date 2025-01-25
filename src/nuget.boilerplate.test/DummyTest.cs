using nuget_boiler_plate;

namespace nuget.boilerplate.test;

public class DummyTest
{
    [Fact]
    public void Test1()
    {
        var class1 = new Class1("John", 30);

        Assert.Equal("John", class1.GetName());
        Assert.Equal(30, class1.GetAge());
    }
    
    [Fact]
    public void Test2()
    {
        var class2 = new Class2();

        Assert.NotNull(class2);
    }
}