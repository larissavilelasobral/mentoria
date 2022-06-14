class Program
{
  static void Main(string[] args)
  {
    //parâmetro: [10, 5, 4, 1, 9, 22, 21, 23]
    int[] cars = { 0, 5, 4, 1, 9, 22, 21, 23 };
    passa(cars);

    // for (int i = 0; i < 5; i++)
    // {
    //   Console.WriteLine(i);
    // }
  }

  static int passa(params int[] cars)
  {
    int indexA = 0;
    int indexB = 0;
    foreach (int a in cars)
    {
      Console.WriteLine(indexA);
      indexA++;

      foreach (int b in cars)
      {
        indexB++;
        if (cars[indexB] > cars[indexA])
        {
          int reserva = cars[indexB];

          cars[indexB] = cars[indexA];
          cars[indexA] = reserva;
        }
      }
    }
    return 
  }
}