namespace Projeto
{
  public class Imc
  {
    private double peso;
    private double altura;

    public double Peso { get => peso; set => peso = value; }
    public double Altura { get => altura; set => altura = value; }

    public double CalcularImc(double peso, double altura)
    {
      // peso invalido
      if (peso <= 0)
      {
        throw new ArgumentException("Peso invalido!");
      }

      double quadradoDaAltura = altura * altura;
      double imc = peso / quadradoDaAltura;

      return imc;
    }

    public void FiltrarIMC(double imc)
    {
      if (imc < 18.5) {
        Console.Write("Abaixo do peso");
      }
      else if (imc > 18.5 && imc < 25) {
        Console.Write("Peso ideal");
      }
      else if (imc > 25 && imc < 30) {
        Console.Write("Sobrepeso");
      }
      else if (imc > 30 && imc < 40) {
        Console.Write("Obesidade");
      }
      else if (imc > 40) {
        Console.Write("Obseidade mórbida");
      }
    }
  }
}