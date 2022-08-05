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
    // verifcar se a função Resultado retorna True
    // Resultado(true)
    bool valorEnviado = false;
    bool valorRetornado = Program.Resultado(valorEnviado);
    Assert.AreEqual(true, valorRetornado);
  }
}