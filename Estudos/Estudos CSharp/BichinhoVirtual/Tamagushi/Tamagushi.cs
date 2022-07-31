namespace BichinhoVirtual
{
  public class Tamagushi
  {
    private string nome;
    public string fome;
    public string saude;
    public string idade;

    public string Nome { get => nome; set => nome = value; }

    public string AlterarNome(string novoNome)
    {
      this.Nome = novoNome;

      return this.Nome;
    }

    public void AlterarFome(string novoFome)
    {
      this.fome = novoFome;
    }

    public void AlterarSaude(string novoSaude)
    {
      this.saude = novoSaude;
    }

    public void AlterarIdade(string novoIdade)
    {
      this.idade = novoIdade;
    }
  }
}
