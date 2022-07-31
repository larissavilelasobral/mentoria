using System;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Armadura armaduraFelina = new Armadura();
      armaduraFelina.Nome = "Armadura Felina";
      armaduraFelina.Defesa = 30.5;
      armaduraFelina.ExibirDefesa();
      
      Console.WriteLine("--------------------");
      Aprimorada armaduraAprimorada = new Aprimorada();
      armaduraFelina.Nome = "Armadura Felina Aprimorada";
      armaduraFelina.Defesa = 30.5;
      armaduraFelina.ExibirDefesa();
    }
  }
}