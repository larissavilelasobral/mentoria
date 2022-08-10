namespace PokemonApp.tests;

public class Tests
{
  [SetUp]
  public void Setup()
  {


  }

  [Test]
  public void Test_Batalha_Retonar_Vencedor()
  {
    // verifcar pokemon vencedor
    int pokemonDoUsuarioBulbasauro = 0; //90
    int pokemonDaMaquinaAguaasauro = 1; //900

    // Batalha(usuario, maquina)
    int pokemonVencedor = Program.Batalha(pokemonDoUsuarioBulbasauro, pokemonDaMaquinaAguaasauro);
    Assert.AreEqual(pokemonDaMaquinaAguaasauro, pokemonVencedor);
  }

  [Test]
  public void Test_Resultado_Retonar_True()
  {
    var stringWriter = new StringWriter();
    Console.SetOut(stringWriter);

    Program.Resultado(true);
    string mensagemVitoria = ">>>>>> Parabens!! Você ganhou! <<<<<<";
    Assert.AreEqual(mensagemVitoria, stringWriter.ToString());
  }
}