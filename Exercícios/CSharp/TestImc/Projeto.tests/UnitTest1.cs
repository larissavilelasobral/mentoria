namespace Projeto.tests;

public class Tests
{
  private Imc _larissa;

  [SetUp]
  public void Setup()
  {
    _larissa = new Imc();
  }

  [Test]
  public void Test_calcularIMC_return()
  {
    // arrange
    double peso = 70;
    double altura = 1.70;
    double imcEsperado = 24.221453287197235;
    
    // act 
    double imcCalculado = _larissa.CalcularImc(peso, altura);

    // assert
    Assert.AreEqual(imcEsperado, imcCalculado);
  }

  [TestCase(18, "Abaixo do peso")]
  [TestCase(20, "Peso ideal")]
  [TestCase(28, "Sobrepeso")]
  [TestCase(31, "Obesidade")]
  [TestCase(42, "Obseidade mórbida")]
  public void Test_calcularIMC_filter_return(double imc, string mensagemEsperada)
  {
    var stringWriter = new StringWriter();
    Console.SetOut(stringWriter);

    _larissa.FiltrarIMC(imc);
    
    Assert.AreEqual(mensagemEsperada, stringWriter.ToString());
  }

  // testa exeption
}