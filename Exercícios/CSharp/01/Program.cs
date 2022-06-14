using bytebak;

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

      // Console.WriteLine("Nome do titular: "+conta1.titular);
      // Console.WriteLine(conta1.conta);
      // Console.WriteLine(conta1.nome_agencia);
      // Console.WriteLine(conta1.saldo);
      // Console.WriteLine(conta1.verificador);

      // Console.WriteLine("Saldo da amanada pre-saque: " + conta2.saldo);
      // bool saque = conta2.Sacar(50);
      // Console.WriteLine("Saque realizado? " + saque);
      // Console.WriteLine("Saldo da amanada pos-saque: " + conta2.saldo);
      // conta2.Depositar(60);
      // Console.WriteLine("Saldo da amanada pos-deposito: " + conta2.saldo);

      // Console.WriteLine("Saldo da andre pos-deposito: " + conta1.saldo);
      // Console.WriteLine("Saldo da amanada pos-deposito: " + conta2.saldo);
      // conta1.Trasferir(50, conta2);
      // Console.WriteLine("Saldo da andre pos-deposito: " + conta1.saldo);
      // Console.WriteLine("Saldo da amanada pos-deposito: " + conta2.saldo);
    
      conta1.Extrato();

      // objeto
      Cliente cliente = new Cliente();
      cliente.nome = "Larissa";
      cliente.cpf = "1234";
      cliente.profissao = "dev";
      
    }
  }
}