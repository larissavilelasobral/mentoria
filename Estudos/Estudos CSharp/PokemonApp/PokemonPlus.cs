namespace PokemonApp
{
  public class PokemonPlus : Pokemon
  {
    // constructor
    public PokemonPlus() : base() // usa como base o constructor sem parametro.
    {
      this.Poder = 0;
    }

    // usa como base o constructor com parametro.
    public PokemonPlus(String nome, String descricao, int poder) : base(nome, descricao)
    {
      this.Poder = poder;
    }

    public int Poder { get; set; } // pokemon que tiver mais poder vence a batalha.

    // exibir dados porem agora com a opçao de poder()

    public void ExibirDadosPokemonPlus()
    {
      Console.WriteLine($"\n Nome do Pokémon: {this.Nome} \n Descrição do Pokemon: {this.Descricao} \n Poder: {this.Poder}");
    }
  }
}