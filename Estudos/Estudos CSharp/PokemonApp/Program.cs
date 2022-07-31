using System;

namespace PokemonApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // lista toda a lista de pokemons
      Pokedex pokedex = new Pokedex();
      
      //pokedex.ListarPokemons();
      int resp = 100;
      while (resp !=0)
      {
        resp = Menu();

        if(resp == 1)
        {
          pokedex.ListarPokemons();
        }
        if( resp == 2)
        {
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
          // batalha
          //Dados dos pokémons que irão lutar
          Console.WriteLine(" ------- Dados do seu pokémon ------- ");
          pPlayer.ExibirDadosPokemonPlus();

          Console.WriteLine(" ------- Dados do pokémon do PC ------- ");
          pPc.ExibirDadosPokemonPlus();

          if (pPlayer.Poder >= pPc.Poder)
          {
            Console.WriteLine(">>>>>> Parabens!! Você ganhou! <<<<<<");
          }
          else {
            Console.WriteLine(">>>>>> Que pena! Você perdeu! <<<<<<");
          }
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
  }
}
// mostrar nome e descrição dos pokemons.
// criar uma classe para a pokedex/agenda.
// mostrar todos os pokemons existentes.

