using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace asyncmain
{
    class Program
    {
        static async Task Main() 
        {
             using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"https://api.nasa.gov/planetary/apod");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    
                // You don't need await here
                var result = await client.GetStringAsync("?concept_tags=True&api_key=DEMO_KEY");
                Console.WriteLine(result);
            }
        }
    }
}
