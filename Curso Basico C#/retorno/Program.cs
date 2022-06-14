class Program
{
  // quando um valor inicial é definido os outros seguem
  enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}
  static void Main(string[] args)
  {
    Console.WriteLine("-------- Função Main --------");

    Console.WriteLine("Selecione uma das opções abaixo: ");
    Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");

    int index = int.Parse(Console.ReadLine());
    Opcao opcaoSelecionada = (Opcao)index;

    Console.WriteLine(opcaoSelecionada);

    switch (opcaoSelecionada)
    {
      case Opcao.Criar:
        Console.WriteLine("vc quer criar algo");
        break;
      case Opcao.Deletar:
        Console.WriteLine("vc quer deletar algo");
        break;
      case Opcao.Atualizar:
        Console.WriteLine("vc quer atualizar algo");
        break;
      case Opcao.Listar:
        Console.WriteLine("vc quer listar algo");
        break;
      default:
        Console.WriteLine("opção não encontrada");
        break;
    }

    Console.ReadLine();    
  }
}
