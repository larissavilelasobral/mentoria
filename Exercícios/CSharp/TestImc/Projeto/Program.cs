using System;

namespace Projeto
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Uma pessoa com 1,70 m e 70 kg fará o seguinte cálculo
      // Altura multiplicada por ela mesma: 1,70 x 1,70 = 2,89
      // Peso dividido pelo quadrado da altura: 70 / 2,89 = 24,22
      //IMC de 24.

      double peso = 70;
      double altura = 1.70;

      Imc pessoa1 = new Imc();
      // tratamento de erro
      double result = 0.0;
      try
      {
        result = pessoa1.CalcularImc(peso, altura);
        Console.WriteLine(result);
      }
      catch(ArgumentException e)
      {
        Console.WriteLine(e.Message);
      }
      
      //pessoa1.FiltrarIMC(result);
    }
  }
}