using System;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Person person1 = new Person();
      Console.WriteLine(person1.Name);

      var person2 = new Person("Sarah Jones");
      Console.WriteLine(person2.Name);
    }
  }
}