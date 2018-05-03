using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._1
{
    //https://github.com/dotnet/csharplang/issues/190
    class tuples_equality
    {
        public void Run()
        {
            var tuple1 = (15, 20);
            var tuple2 = (15, 20);
            var tuple3 = (15, 10);
            
            //existing - nothing new
            if (tuple1.Equals(tuple2))
            {
                //This is true
            }
            var theTup = (1, 2, 3, 4, 5);
            

#if CSharp_FUTURE
            
            //Coming..//shallow equality checking
            if (tuple1 == tuple2)
            {

            }
            if((x, y) == (1, 2))
            {

            }
#endif
        }
    }
}
