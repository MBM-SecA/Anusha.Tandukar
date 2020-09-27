using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;

namespace Async
{
    class Program
    {
        static void Main()
        {
        //Make breakfast

        //Make tea
        // - Turn Kettle in burner (3s)
        // - Pour water (5s)
        // - Let it boil (5min)
        // - Grind masalas (1min)
        //- Put sugar and masalas (5s)
        // - Pour milk (5s)
        // - Let it boil (3min)
  

        // - Turn on burnet (2s)
        // - Put pan on and oil it (30s)
        // - Crack eggs and whisk it (3min)
        // - Fry (3min)

        Stopwatch stopwatch = Stopwatch.StartNew();
        HttpClient client = new HttpClient();
       
        var google = client.GeStringAsync("www.google.com").Result;
        var m = client.GeStringAsync("www.microsoft.com").Result;
        var a = client.GeStringAsync("www.amazon.com").Result;
        Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds}ms");

        stopwatch.Restart();
         var gg= client.GeStringAsync("www.google.com");
        var mm = client.GeStringAsync("www.microsoft.com");
        var aa = client.GeStringAsync("www.amazon.com");
        Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds}ms");
        


        }
    }
}
