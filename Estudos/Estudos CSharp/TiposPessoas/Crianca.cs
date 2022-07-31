public class Crianca: Pessoa
{
  public void FaixaEtaria() => Console.WriteLine($"{this.Nome} tem {this.Idade} anos, então é menor de idade."); //interpolação de cadeia de caracteres
}