public class Arma
{
  private string nome; // nome da espada
  private double dano = 10.3; // 10.3
  private double nivel = 30; // 30
  private string tipo; //Espada de Aço

  public double Nivel { get => nivel; set => nivel = value; }
  public double Dano { get => dano; set => dano = value; }

  public void Ataque()
  {
    double forca = this.Dano+this.Nivel;
    Console.WriteLine("Força de Ataque: "+forca);
  }
}