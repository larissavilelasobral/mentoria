using System;

namespace TiposPessoas
{
  public class Tipos
  {
    public static void Main(string[] args)
    {
      Pessoa pessoa1 = new Pessoa();
      pessoa1.Nome = "Larissa";
      pessoa1.Idade = 20;
      pessoa1.ExibirDados();

      Console.WriteLine("--------------------");
      Crianca pessoa2 = new Crianca();
      pessoa2.Nome = "Lucia";
      pessoa2.Idade = 12;
      pessoa2.FaixaEtaria();
      pessoa2.ExibirDados();

      Console.WriteLine("--------------------");
      Adulto pessoa3 = new Adulto();
      pessoa3.Nome = "João";
      pessoa3.Idade = 35;
      pessoa3.CarteiraDeHabilitacao();
      pessoa3.ExibirDados();
    }
  }
}
