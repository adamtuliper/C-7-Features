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
    }
}
