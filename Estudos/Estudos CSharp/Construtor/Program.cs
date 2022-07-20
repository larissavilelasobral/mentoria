using System;

namespace ConsoleApp
{
  public class Taxi
  {
    public bool IsInitialized;

    public Taxi()
    {
      IsInitialized = true;
    }
  }

  public class Person
  {
    private string last;
    private string first;

    public Person(string firstName, string lastName)
    {
      last = lastName;
      first = firstName;
    }

    public void ApresentarDados()
    {
      Console.WriteLine("Nome Completo: {0} {1}", first, last);
    }

    /*
    public string Last
    {
      get { return last; }
      set { last = value; }
    }
    */
  }

  class TestTaxi
  {
    static void Main()
    {
      Taxi carro = new Taxi();
      Console.WriteLine(carro.IsInitialized);

      Person nomeCompleto = new Person("Larissa", "Vilela");
      nomeCompleto.ApresentarDados();
      nomeCompleto.Last();
    }
  }
}
