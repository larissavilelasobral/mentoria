using System;

namespace PokemonApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Pokedex pokedex = new Pokedex();
      //Menu
      int resp = 100;
      while (resp != 0)
      {
        resp = Menu();
        if (resp == 1) // mostrar apenas a lista de pokemons
        {
          pokedex.ListarPokemons();
        }
        if (resp == 2) // batalha
        {
          bool resul = Batalha();
          Resultado(resul);
        }
        Console.ReadKey();
        Console.Clear();
      }

      // liscar um pokemon por vez
      //Pokemon p = pokedex.Pokemons[1];
      //p.ExibirDadosPokemon();
    }

    static int Menu()
    {
      Console.WriteLine("Pokémon ---- Jogo de Batalha");
      Console.WriteLine("0 - Sair da pokedex");
      Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
      Console.WriteLine("2 - Batalhar");
      Console.WriteLine("O que deseja fazer: ");
      // converte para inteiro o que eu receber pelo terminal
      int resp = Convert.ToInt32(Console.ReadLine());

      return resp;
    }

    static bool Batalha()
    {
      Pokedex pokedex = new Pokedex();
      // mostrar todos os pokemons
      pokedex.ListarPokemons();
      // escolher um pokemon da lista.
      Console.WriteLine("Digite o código do pokémon: ");
      // capturar a respotas e converter para inteiro.
      int codigo = Convert.ToInt32(Console.ReadLine());

      // pegar o pokemon do jogador na lista.
      PokemonPlus pPlayer = pokedex.Pokemons[codigo];
      // definir o pokemon do pc que vai batalhar contra ele.
      Random aleatorio = new Random();
      // vai pegar um valor de 0-tamanho da lista
      codigo = aleatorio.Next(0, pokedex.Pokemons.Count);
      // capturar pokemon do pc.
      PokemonPlus pPc = pokedex.Pokemons[codigo];

      //Dados dos pokémons que irão lutar
      Console.WriteLine(" ------- Dados do seu pokémon ------- ");
      pPlayer.ExibirDadosPokemonPlus();

      Console.WriteLine(" ------- Dados do pokémon do PC ------- ");
      pPc.ExibirDadosPokemonPlus();

      if (pPlayer.Poder >= pPc.Poder)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    static void Resultado(bool resul)
    {
      if (resul == true)
      {
        string venceu = ">>>>>> Parabens!! Você ganhou! <<<<<<";
        Console.WriteLine(venceu);
      }
      else
      {
        string perdeu = ">>>>>> Que pena! Você perdeu! <<<<<<";
        Console.WriteLine(perdeu);
      }
    }
  }
}
// mostrar nome e descrição dos pokemons.
// criar uma classe para a pokedex/agenda.
// mostrar todos os pokemons existentes.

