public class Pessoa
{
  private string nome = "";
  private int idade = 0;

  public int Idade { get => idade; set => idade = value; }
  public string Nome { get => nome; set => nome = value; }

  public void ExibirDados()
  {
    Console.WriteLine("Nome: " + this.Nome);
    Console.WriteLine("Idade: " + this.idade);
  }
}