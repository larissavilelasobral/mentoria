namespace PokemonApp
{
  public class Pokedex
  { //propfull

    // construtor
    public Pokedex()
    {
      // iniciar a nossa lista
      this.InicializaLista();
    }

    // mudar para PokemonPlus, para utilizar a propriedade de poder()
    // private List<Pokemon> pokemons;
    // public List<Pokemon> Pokemons
    // { 
    //   get { return pokemons; } // os usuarios só vão conseguir ler os dados e não setar.
    // }

    private List<PokemonPlus> pokemons;

    public List<PokemonPlus> Pokemons
    { 
      get { return pokemons; } // os usuarios só vão conseguir ler os dados e não setar.
    }

    private void InicializaLista() // só a classe vai pode utilizar
    {
      // Instanciar a lista
      this.pokemons = new List<PokemonPlus>();
      PokemonPlus p = new PokemonPlus("Bulbasauro", "Pokemon tipo planta", 90); // escolher qual construtor utilizar
      this.pokemons.Add(p); // inserir na sua lista (como a nossa propriedade só tem get então utilizamos a variavel)
      p = new PokemonPlus("Aguaasauro", "Pokemon tipo agua", 900);
      this.pokemons.Add(p);
      p = new PokemonPlus("Terrasauro", "Pokemon tipo terra", 92);
      this.pokemons.Add(p);
      p = new PokemonPlus("Ventoasauro", "Pokemon tipo vento", 95);
      this.pokemons.Add(p);
      p = new PokemonPlus("Vegetalasauro", "Pokemon tipo vegetal", 59);
      this.pokemons.Add(p);
      p = new PokemonPlus("Ferroasauro", "Pokemon tipo ferro", 19);
      this.pokemons.Add(p);
      p = new PokemonPlus("Luasauro", "Pokemon tipo lua", 69);
      this.pokemons.Add(p);
      p = new PokemonPlus("Solasauro", "Pokemon tipo sol", 9);
      this.pokemons.Add(p);
      p = new PokemonPlus("Nuvemasauro", "Pokemon tipo nuvem", 89);
      this.pokemons.Add(p);
      p = new PokemonPlus("Chuvaasauro", "Pokemon tipo chuva", 39);
      this.pokemons.Add(p);
    }

    public void ListarPokemons()
    {
      for (var i = 0; i < this.pokemons.Count; i++) //cont diz quantos elementos tem na lista
      {
        // vai ajudar o usuario a escolher seu pokemon com base no index da lista
        Console.WriteLine("Código do Pokémon: " +i); 
        this.pokemons[i].ExibirDadosPokemon();
        // ou
        //Pokemon p = this.pokemons[i];
        //p.ExibirDadosPokemon();
      }
    }
  }
}

