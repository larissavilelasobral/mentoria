using System;

namespace ControleDeArtes
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<Arte> Artes = new List<Arte>();
      int numero = 0;

      Arte arte; // instancia lá em baixo

      Console.WriteLine("Controle de Obras de Arte: ");
      Console.Write("Quantas obras voce quer inserir: ");
      numero = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("iniciando o cadastro das obras de arte");
      for (var i = 0; i < numero; i++)
      {
        Console.WriteLine("Leitura da Obra {0}", i);
        
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Descrição: ");
        string descricao = Console.ReadLine();
        arte = new Arte(nome, descricao);
        Artes.Add(arte);
      }

      Console.WriteLine("Lista das obras cadastradas: ");
      for (var i = 0; i < numero; i++)
      {
        Artes[i].ExibirDados();
      }
      Console.ReadKey();
    }
  }
}

// Possuir uma interface com o nome de IArte;