using System;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ISampleInterface obj = new ImplementationClass();

      // Call the member.
      obj.SampleMethod();
    }
  }
}