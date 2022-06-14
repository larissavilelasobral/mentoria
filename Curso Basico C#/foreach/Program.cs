class Program
{
  static void Main(string[] args)
  {
    string[] palavras = {"Victo", "oi", "deus"};
    
    foreach (string palavra in palavras)
    {
      Console.WriteLine(palavra);
    } 

    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine(i);
    }
  }
}