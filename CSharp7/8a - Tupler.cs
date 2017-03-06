using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    public class Tupler
    {
        //in REPL to include library reference
        //#r     \c sharp 7\packages\System.ValueTuple.4.0.0-rc3-24212-01\lib\netstandard1.1\System.ValueTuple.dll

        /// <summary>
        /// Azure portal URL.
        /// </summary>
        private const string BaseUrl = "https://westus.api.cognitive.microsoft.com/";

        /// <summary>
        /// Your account key goes here.
        /// </summary>
        private const string AccountKey = "2fb915f0cc1747bd99b98148355fe177";

        /// <summary>
        /// Maximum number of languages to return in language detection API.
        /// </summary>
        private const int NumLanguages = 1;


        public async static Task<(string keyPhrases, string language, string sentiment)> ProcessLanguage()
        {

            var (s,r,w) = await MakeRequests();
            //We now have each var to work not in a named tuple
            Console.WriteLine($"{s} {r} {w}");

            //Now these are private in a tuple struct
            (string s,string r,string w) results = await MakeRequests();

            (var a, var b, var c) = await MakeRequests();

            //No workie - as we're not creating a,b,c, we're creating a tuple named results, hence dont need internal var
            //(var a, var b, var c) results = await MakeRequests();

            var result = await MakeRequests();

            return result;
            //(int num, int count) = (num: 1, count: 4);
            //int (x,y) = (num:1, sum:5);

        }

        static async Task<(string keyPhrases, string language, string sentiment)> MakeRequests()
        {

            //Note usage of default. You can't use 'new' with a tuple type
            var responses = default((string keyPhrases, string languages, string sentiment));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);

                // Request headers.
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", AccountKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Request body. Insert your text data here in JSON format.
                byte[] byteData = Encoding.UTF8.GetBytes("{\"documents\":[" +
                    "{\"id\":\"1\",\"text\":\"hello world\"}," +
                    "{\"id\":\"2\",\"text\":\"hello foo world\"}," +
                    "{\"id\":\"three\",\"text\":\"hello my world\"},]}");

                // Detect key phrases
                var uri = "text/analytics/v2.0/keyPhrases";
                var response = await CallEndpoint(client, uri, byteData);
                Console.WriteLine("\nDetect key phrases response:\n" + response);
                responses.keyPhrases = response;

                // Detect language
                uri = "text/analytics/v2.0/languages?numberOfLanguagesToDetect=1";
                response = await CallEndpoint(client, uri, byteData);
                Console.WriteLine("\nDetect language response:\n" + response);
                responses.languages = response;

                // Detect sentiment
                uri = "text/analytics/v2.0/sentiment";
                response = await CallEndpoint(client, uri, byteData);
                Console.WriteLine("\nDetect sentiment response:\n" + response);
                responses.sentiment = response;


                //Return tuple
                return responses;
            }
        }

        static async Task<String> CallEndpoint(HttpClient client, string uri, byte[] byteData)
        {
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(uri, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}
