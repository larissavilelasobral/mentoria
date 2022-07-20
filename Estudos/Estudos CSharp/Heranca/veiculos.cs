public class Veiculos
{
  // atributos
  private string nome = "";
  private decimal valor = 0;
  private string marca = "";

  public Veiculos()
  {
    //construtor 
  }

  public void NomeMaiusculo()
  {
    //método
  }

  public virtual void ValorTotal()
  {
    //método original que pode ser alterado na subclasse
  }
}

public class Moto : Veiculos
{
  //herda implicitamente todos os atributos
  //herdou implicitamente todos os métodos
  //não herda o construtor

  //para modificar um método ele deve ser virtual na classe base
  //e override na classe derivada 
  
  //exemplo:
  public override void ValorTotal()
  {
    //método alterado
  }

}