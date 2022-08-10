namespace BichinhoVirtual
{
  public class Tamagushi
  {
    private string nome = "";
    public bool fome = false;
    public decimal saude = 0.0;
    public int idade = 0;

    public string AlterarNome(string novoNome)
    {
      this.nome = novoNome.ToUpper();

      return this.nome;
    }

    public void AlterarFome(bool novoFome)
    {
      this.fome = novoFome;
    }

    public void AlterarSaude(decimal novoSaude)
    {
      this.saude = novoSaude;
    }

    public void AlterarIdade(int novoIdade)
    {
      this.idade = novoIdade;
    }
  }
}
