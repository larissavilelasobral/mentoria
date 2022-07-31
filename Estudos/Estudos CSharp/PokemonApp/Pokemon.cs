namespace PokemonApp
{
  public class Pokemon
  {
    // construtor basico
    public Pokemon()
    {
      this.Nome = ""; // nome começa em branco sempre que um novo pokemon é criado.
      this.Descricao = "";
    }

    // sobrecarga de construtor
    public Pokemon(String nome, String descricao)
    {
      this.Nome = nome;
      this.Descricao = descricao;
    }

    private String nome; // nome do pokemon

    public String Nome // propriedade
    {
      get
      {
        return nome;
      }
      set
      {
        String texto = value.ToUpper(); // alterar pra string e maiusculo
        nome = texto;
      }
    }

    private String descricao; // armazena o valor da propriedade Descricao

    public String Descricao // representa a caracteristica Descricao do meu pokemon
    {
      get
      {
        return this.descricao;
      }
      set
      {
        this.descricao = value.ToUpper();
      }
    }

    // metodo para exibir todas as info do pokemon(uma ação que ira executar)
    public void ExibirDadosPokemon()
    {
      Console.WriteLine("Nome do Pokemon: " + this.Nome);
      Console.WriteLine("Descrição do Pokemon: " + this.Descricao);
    }

    public void ExibirDadosPokemon(Boolean formato)
    {
      if (formato == true)
      {
        Console.WriteLine($"Pokemon {this.Nome}: {this.Descricao.ToLower()}");
      }
      else
      {
        Console.WriteLine($"Nome do Pokemon: {this.Nome}");
        Console.WriteLine($"Descrição do Pokemon: {this.Descricao}");
      }

    }

  }
}