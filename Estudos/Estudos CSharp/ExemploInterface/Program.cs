using System;

namespace Aula_Interface2
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Interface");

      RegistroOcorrencia reg = new RegistroOcorrencia();
      reg.RegistroOcorrencia("Texto 1");
    }
  }
}