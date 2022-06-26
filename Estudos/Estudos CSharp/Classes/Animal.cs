namespace ProgramaPrincipal
{
  class Animal
  {
    private int idade = 10;
    private double peso = 50.4;

    // qual a diferença dos metodos abaixo? //()
    public int ObterIdade()
    {
      return idade;
    }

    // é tipo uma variavel(não um metodo) que só vai retornar o valor
    public double ObterPeso{get { return peso; }}
  }
}