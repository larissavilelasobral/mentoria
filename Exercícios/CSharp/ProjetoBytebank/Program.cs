

// control k c 
// valores padrão
namespace ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente conta1 = new ContaCorrente();
      conta1.titular = "Andre silva";
      conta1.conta = "1234-x";
      conta1.nome_agencia = "agencia central";
      conta1.saldo = 100;

      ContaCorrente conta2 = new ContaCorrente();
      conta2.titular = "amanda";
      conta2.conta = "1872-x";
      conta2.nome_agencia = "agencia norte";
      conta2.saldo = 300.50;
    
      conta1.Extrato();

      // objeto
      Cliente cliente = new Cliente();
      cliente.nome = "Larissa";
      cliente.cpf = "1234";
      cliente.profissao = "dev";
      
    }
  }
}