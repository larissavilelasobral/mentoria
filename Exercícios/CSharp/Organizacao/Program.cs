using System;

namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[] itens = new string[3];
      itens[0] = "x-tudo";
      itens[1] = "pastel";
      itens[2] = "refri";

      Console.WriteLine(String.Join(" - ", itens));

      Cardapio(itens);

    }

    public string Cardapio(string[] numero)
    {
      string nomePedido = "";

      for (var i = 0; i < numero.length; i++)
      {
        switch (numero[i])
        {
          case "x-tudo":
            nomePedido = "X-Tudo";
            this.valor = 6.50;
            break;
          case "pastel":
            nomePedido = "Batata";
            this.valor = 4.00;
            break;
          case "refri":
            nomePedido = "Coca-Cola";
            this.valor = 5.00;
            break;
          case "4":
            nomePedido = "Pepsi Cola";
            this.valor = 3.50;
            break;
          default:
            break;
        }
        return nomePedido;
      }
    }

  }
}

