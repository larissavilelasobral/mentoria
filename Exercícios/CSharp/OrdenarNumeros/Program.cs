class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("----- Função Principal -----");

    int[] numerosAleatorios = new int[5];
    Console.WriteLine(numerosAleatorios);
    numerosAleatorios[3] = 1;
    numerosAleatorios[0] = 10;
    numerosAleatorios[1] = 5;
    numerosAleatorios[4] = 9;
    numerosAleatorios[2] = 4;
    Console.WriteLine(numerosAleatorios[1]);

    Console.WriteLine(numerosAleatorios.Length);
 
    ordenarLista(numerosAleatorios);
  }

  static void ordenarLista(int[] numerosAleatorios)
  {
    Console.WriteLine("----- Função de Ordenar -----");

    foreach (var numero in numerosAleatorios)
    {
      int indexA = numero;
      Console.WriteLine(indexA);
      Console.WriteLine("numero: " + numerosAleatorios[1]);
    }
  }
}

//Escreva um programa que tenha uma função que receba uma lista aleatória de números e 
//retorne uma lista ordenada.

//Ex.: 
//parâmetro: [10, 5, 4, 1, 9, 22, 21, 23]
//retorno: [1, 4, 5, 9, 10, 21, 22, 23]