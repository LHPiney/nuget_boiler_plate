namespace nuget_boiler_plate;

public class Class1
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Class1(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }
}