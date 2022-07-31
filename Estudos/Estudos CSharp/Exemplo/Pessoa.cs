using System;

public class Person
{
    public Person()
    {
      Name = "unknown";
    }

    public Person(string name)
    {
      Name = name;
    }

    public string Name { get; }

    public override string ToString()
    {
      return Name;
    }
}
