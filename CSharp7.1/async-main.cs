using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._1
{
    class async_main
    {
#if CSharp71


        static Task Main() => null;

        static Task<int> Main() => null;

        static Task Main(string[]) => null;

        static Task<int> Main(string[]) => null;
#endif
    }
}
