class Program
{
  static void Main(string[] args)
  {
    int[] numerosDesordenados = { 10, 5, 4, 1, 9, 22, 21, 23 };

    foreach (int numeros in numerosDesordenados)
    {
      Console.WriteLine(numeros);
    }

    OrdenarNumeros(numerosDesordenados);
    Console.WriteLine("--------------------");

    foreach (int numeros in numerosDesordenados)
    {
      Console.WriteLine(numeros);
    }
  }

  static void OrdenarNumeros(int[] numerosDesordenados)
  // tem um erro na função.
  {
    int indexA = 0;
    int indexB = 0;
    foreach (int a in numerosDesordenados)
    {
      indexA++;
      foreach (int b in numerosDesordenados)
        indexB++;
      {
        if (numerosDesordenados[indexB] > numerosDesordenados[indexA])
        {
          int reserva = numerosDesordenados[indexB];

          numerosDesordenados[indexB] = numerosDesordenados[indexA];
          numerosDesordenados[indexA] = reserva;
        }
      }
    }
  }
}