namespace ControleDeArtes
{
  public class Arte : IArte
  {
    private string Nome;
    private string Descricao;

    public Arte()
    {
      this.Nome = "";
      this.Descricao = "";
    }

    public Arte(string nome, string descricao)
    {
      this.Nome = nome;
      this.Descricao = descricao;
    }

    public void ExibirDados()
    {
      Console.WriteLine($"Arte: {this.Nome} Descrição: {this.Descricao}");
    }
  }
}