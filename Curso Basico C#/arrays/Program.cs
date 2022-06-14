class Program
{
  // enum Cor { Azul = 33, Verde = 78, Amarelo = 178, Vermelho = 240 }
  enum Cor { Azul, Verde, Amarelo, Vermelho }
  static void Main(string[] args)
  {
    Cor corFavorita = Cor.Azul;

    Console.WriteLine(corFavorita);
    String text = "Converter o tipo! retorna o index a baixo";
    Console.WriteLine((int)corFavorita);

    QuintaFuncao();

    string[] cofre = new string[3];
    cofre[0] = "Larissa";
    cofre[1] = "laiza";
    cofre[2] = "guilherme";

    int size = cofre.Length;

    Console.WriteLine("função principal");
    SegundaFuncao();

    String terceira = TerceiraFuncao();

    Console.WriteLine(terceira);

    float resultado = QuartaFuncao(6, 6);

    Console.WriteLine("resultado da quarta função: "+resultado);
  }

  static void SegundaFuncao()
  {
    String text = "segunda função que só será exibida/executada quando estiver sendo chamada na main";
    Console.WriteLine(text + "não tem return na função por causa do void");
  }

  static String TerceiraFuncao()
  {
    String text = "função com return que retonar com um tipo definido, no caso string";

    return text;
  }
    static float QuartaFuncao( int valor1, float valor2)
  {
    float res = valor1 + valor2;

    return res;
  }
  static void QuintaFuncao()
  {
    Console.WriteLine("--------- Estudos Switch ---------");
    string cor = "verde";

    switch (cor){
      case "Vermelho":
        Console.WriteLine("sua cor é vermelho");
        break;
      case "Amarelo":
        Console.WriteLine("amarelo");
        break;
      case "Azul":
        Console.WriteLine("sua cor é azul");
        break;
      default:
        Console.WriteLine("o else do switch");
        break;
    }

    Console.WriteLine("Fim");
  }

  static void SextaFuncao()
  {
    Console.WriteLine("--------- Enum ---------");

    
    
  }
}