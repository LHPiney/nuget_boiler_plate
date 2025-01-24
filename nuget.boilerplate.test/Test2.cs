using nuget_boiler_plate;

namespace nuget.boilerplate.test;

public class Test2
{
    [Fact]
    public void Test1()
    {
        var class1 = new Class1();

        Assert.NotNull(class1);
    }
}