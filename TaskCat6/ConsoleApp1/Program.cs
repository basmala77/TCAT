using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(await FetchData());
            Console.ReadLine();
        }
        static async Task<string> FetchData()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://icy-archduke-e8e.notion.site/NET-Test-4e92251f464a47dea170154e897a2872");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}