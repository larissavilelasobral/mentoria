public class Armadura
{
  private string nome;
  private double defesa;

  public string Nome { get => nome; set => nome = value; }
  public double Defesa { get => defesa; set => defesa = value; }

  public virtual void ExibirDefesa()
  {
    Console.WriteLine($"Valor de Defesa da {this.Nome}, é igual a: {this.Defesa}");
  }
}