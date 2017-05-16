using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._1
{
    class tuple_projection_initializers
    {
        internal class bip
        {
            public int f1;
            public int f2;
        }

        void Run()
        {
            var x1 = new bip();

            var tuple = ((x1.f1, x1.f2) = (1, 2));
            
#if CSharp_71
            //inferred naming without (f1: x1.f1, f2:x1.f2)
           tuple.f1 = tuple.f2;
#endif
        }
    }
}
