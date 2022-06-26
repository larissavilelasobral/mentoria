using System;

namespace ProgramaPrincipal
{
  public class Correios
  {
    public static void Main(string[] args)
    {
    
    int idade;
    double peso;

    Animal bicho = new Animal();
    idade = bicho.ObterIdade();
    peso = bicho.ObterPeso;

    Console.WriteLine("A idade é {0}", idade);
    Console.WriteLine("O peso é {0:F}", peso);
    
    }
  }
}