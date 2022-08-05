namespace ConsoleApp
{
  public class Animais
  {
    public static List<Animal> GetAnimais()
    {
      var listaAnimais = new List<Animal>();
      // Inicializa o objeto e o inclui na coleção
      var animal1 = new Animal("Macoratti");
      listaAnimais.Add(animal1);
      var animal2 = new Animal("ASP");
      listaAnimais.Add(animal2);

      return listaAnimais;
    }
  }
}