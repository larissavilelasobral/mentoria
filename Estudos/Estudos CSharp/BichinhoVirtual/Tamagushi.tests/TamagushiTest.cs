using NUnit.Framework;

namespace BichinhoVirtual.tests
{
  [TestFixture]
  public class BichinhoVirtualTests
  {
    private Tamagushi _tamagushi;

    [SetUp]
    public void SetUp()
    {
      _tamagushi = new Tamagushi();
    }

    [Test]
    public void NomeRetornaUmaString()
    {
      var novoNome = "Larissa";
      var result = _tamagushi.AlterarNome(novoNome);
      // recebe uma string
      // altera o nome original para o novo
      // compara se o valor recebido é o mesmo do nome original(se o nome foi atualizado com sucesso)

      // Assert.AreEqual(object expected, object actual);
      Assert.AreEqual(_tamagushi.Nome, result);
    }
  }
}

