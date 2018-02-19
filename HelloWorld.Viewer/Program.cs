using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace HelloWorld.Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var config = builder.Build();
            var baseApiUrl = config["baseApiUrl"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseApiUrl);

                try
                {
                    var response = client.GetAsync("helloworld/").Result;
                    var message = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(message);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Message not found. {e}");
                }
            }

            Console.ReadKey();
        }
    }
}
