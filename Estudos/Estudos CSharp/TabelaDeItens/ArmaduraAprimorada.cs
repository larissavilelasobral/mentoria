public class Aprimorada : Armadura
{
  public override void ExibirDefesa()
  {
    double aprimorar = this.Defesa + 50;
    Console.WriteLine($"Valor de Defesa da {this.Nome}, é igual a: {aprimorar}");
  }
}