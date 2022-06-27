class Principal
{
  static void Main(string[] args)
  {
    Console.WriteLine("Bem Vindo ao UaiFood!");

    Console.WriteLine("Digite seu nome: ");
    var nome = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Digite seu Enderço: ");
    var endereco = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("O que gostaria de pedir? ");
    Console.WriteLine("1.x-tudo \n 2. batata \n 3.coca-cola \n 4.pepsi cola");
    var itens = Console.ReadLine() ?? string.Empty;

    Pedido novoPedido = new Pedido(nome, endereco, itens);
    novoPedido.Cardapio(itens);
    novoPedido.ValorTotal();
    novoPedido.ResumoPedio();
  }
}

// cliemte passa as informações para a entrega;
// mostrar menu numerado de pedidos;
// o cliente escolhe um numero
// cliente informa quel itens quer pedir;
// é calculado o valor total dos itens;
// é retornado o valor total do pedido para o cliente;

//----------------------------------------------------------------//
//Lorena é proprietária de uma franquia de fast food e quer disponibilizar para seus franqueados um sistema de pedidos online. O sistema idealizado por ela deverá trabalhar com informações de pedidos de clientes, como valor total do pedido, cliente, endereço de entrega e os itens selecionados (máximo de 3).

//Te desafiamos a criar uma composição de classes que poderá ser usada no desenvolvimento do sistema da Lorena. Vamos ao desafio?