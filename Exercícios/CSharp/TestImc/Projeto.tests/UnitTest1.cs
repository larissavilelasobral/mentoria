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
  public void Test_calcularIMC_sucesso()
  {
    // arrange
    double peso = 70;
    double altura = 1.70;
    double imcEsperado = 24.221453287197235;

    // act 
    double imcCalculado = _luiz.CalcularImc(peso, altura);

    // assert
    Assert.AreEqual(imcEsperado, imcCalculado);
  }

  [Test]
  public void Test_calcularIMC_error()
  {
    double peso = -70;
    double altura = 1.70;

    Assert.Throws<PesoException>(() => _larissa.CalcularImc(peso, altura));
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

    _luiz.FiltrarIMC(imc);

    Assert.AreEqual(mensagemEsperada, stringWriter.ToString());
  }

  [Test]
  public void Test_calcularIMC_filter_error()
  {
    double imc = -30;
    var ex = Assert.Throws<ArgumentException>(() => _larissa.FiltrarIMC(imc));

    Assert.That(ex.Message, Is.EqualTo("IMC invalido!"));
  }

  // [Test]
  // public void Test_startImc_error()
  // {
  //   var stringWriter = new StringWriter();
  //   Console.SetOut(stringWriter);
  //   double peso = -70;
  //   double altura = 1.70;
    
  //   //Program program = new Program();
  //   Program program = new Program();

  //   Assert.AreEqual("Peso invalido!", stringWriter.ToString());
  // }
}