using System;
using System.Collections.Generic;

namespace nuget_boiler_plate;

public class Class3
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Class3(string name, int age)
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
    
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
