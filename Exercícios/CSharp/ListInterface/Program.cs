using System;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<Animal> listaDeAnimais = Animais.GetAnimais();
      listaDeAnimais.ForEach(animal => Console.WriteLine(animal.Nome));
    }
  }
}

