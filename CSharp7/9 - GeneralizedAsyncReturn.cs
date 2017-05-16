using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    class GeneralizedAsync
    {
        private DateTime _lastUpdate;
        private decimal _lastQuote;

        public async Task<decimal> GetStockQuoteA<T>()
        {
            var quote = await new HttpClient().GetStringAsync("http://quotes");
            return decimal.Parse(quote);
        }

        //Requires package System.Threading.Tasks.Extensions

        public async ValueTask<decimal> GetStockQuoteB<T>()
        {
            if (DateTime.Now.Subtract(_lastUpdate).TotalMilliseconds<2000)
            {
                return _lastQuote;
            }
            else
            {
                _lastUpdate = DateTime.Now;
                var quote = await new HttpClient().GetStringAsync("http://quotes");
                return decimal.Parse(quote);
            }
            
        }


        /* Demo 2 */
        public ValueTask<int> CachedFunc()
        {
            return (cache) ? new ValueTask<int>(cacheResult) : new ValueTask<int>(loadCache());
        }
        private bool cache = false;
        private int cacheResult;
        private async Task<int> loadCache()
        {
            // simulate async work:
            await Task.Delay(100);
            cache = true;
            cacheResult = 100;
            return cacheResult;
        }
    }
}
