using System;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      metodo();
    }

    static void metodo()
    {
      Console.WriteLine("metodo fica dentro de uma classe");
      Console.WriteLine("sem entrada ou saida de dados");
    }

    static void soma(int n1, int n2)
    {
      int res=n1-n2;
      Console.WriteLine("");
    }
  }
}
