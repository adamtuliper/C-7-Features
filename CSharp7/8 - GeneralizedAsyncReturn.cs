using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    class GeneralizedAsync
    {

        //Requires package System.Threading.Tasks.Extensions
        public async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
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
