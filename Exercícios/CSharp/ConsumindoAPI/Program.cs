using System.Net.Http;

class Program
{
  static async Task Main(string[] args)
  {
    // consumir a api
    HttpClient client = new HttpClient { BaseAddress = new Uri( "https://positive-vibes-api.herokuapp.com") };
    var res = await client.GetAsync("quotes/random");

    var content = await res.Content.ReadAsStringAsync();

    Console.WriteLine(content);
  }
}