using System;

namespace Projeto
{
  public class Program
  {
    public static void Main(string[] args)
    {
      double peso = 70;
      double altura = 1.70;

      StartImc(peso, altura);

    }

    public static void StartImc(double peso, double altura)
    {
      Imc pessoa1 = new Imc();
      double result = 0.0;

      try
      {
        result = pessoa1.CalcularImc(peso, altura);
        Console.Write(result);
      }
      catch (Exception e)
      {
        Console.Write(e.Message);
      }
    }
  }
}