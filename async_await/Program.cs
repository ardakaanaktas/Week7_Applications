using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await TaskMethod();
            Console.WriteLine("Main method");
            
            string result  = await FetchingData();
            Console.WriteLine(result);
        }

        static async Task<string> FetchingData()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
            return result;
        }

        static async Task TaskMethod()
        {
            await Task.Delay(3000);

            Console.WriteLine("async op");
        }
    }
}
