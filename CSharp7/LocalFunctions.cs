using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    public static class LocalFunctions
    {

        //great discussion on 'cant we do something like this already'
        //https://github.com/dotnet/roslyn/issues/259
        public static int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
           
            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (p, pp) = Fib(i - 1);
                return (p + pp, p);
            }
            //in preview 4 this must occur after declaration - that should change.
            return Fib(x).current;
        }
    }
}
