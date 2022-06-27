class Pedido // nome da classe
{
  private int valor;
  private string cliente;
  private string endereco;
  private string itens; // (máximo de 3).
  private double resultado; // valor total do menu

  public Pedido(string cliente, string endereco, string itens)
  {
    this.cliente = cliente;
    this.endereco = endereco;
    this.itens = itens;
  }

  public int ValorTotal()
  {
    this.valor = 10;
    return this.valor;
  }

  public double Cardapio(string numero)
  {

    switch (numero)
    {
      case "1":
        Console.WriteLine("x-tudo");
        this.resultado = 3.20;
        break;
      case "2":
        Console.WriteLine("batata");
        this.resultado = 4;
        break;
      case "3":
        Console.WriteLine("coca-cola");
        this.resultado = 3;
        break;
      case "4":
        Console.WriteLine("pepsi cola");
        this.resultado = 5;
        break;
      default:
        Console.WriteLine("erro");
        break;
    }
    // ter 4 opçoes no cardapio
    // printa as opçoes na tela

    return this.resultado;
  }

  public void ResumoPedio()
  {
    Console.WriteLine("------------");
    Console.WriteLine("Resumo do Pedido: \n Cliente: {0} \n Endereço: {1} \n Itens: {2} \n Valor Total: {3} Reais", this.cliente, this.endereco, this.itens, this.resultado);
    Console.WriteLine("------------");
  }
}