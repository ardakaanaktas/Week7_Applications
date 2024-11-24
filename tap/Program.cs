using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tap
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Yumurta Haşlanmaya başladı...");
            await BoilEggAsync();
            Console.WriteLine("Yumurta haşlandı...");
            Console.WriteLine();

            CancellationTokenSource source = new CancellationTokenSource();
            Task<string> task = FetchingDataAsync(source.Token);
            await Task.Delay(5000);
            source.Cancel();

            try
            {
                string result = await task;
                Console.WriteLine(result);
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

           
        }

        static async Task BoilEggAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Eggs boiled...");
        }

        static async Task<string> FetchingDataAsync(CancellationToken token)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
            return result;
        }
    }
}
