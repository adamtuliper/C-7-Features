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

            //inferred naming
           // tuple.x1 = tuple.x2;
        }
    }
}
