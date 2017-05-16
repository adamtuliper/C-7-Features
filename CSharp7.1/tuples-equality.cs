using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._1
{
    class tuples_equality
    {
        public void Run()
        {
            var tuple1 = (15, 20);
            var tuple2 = (15, 20);
            var tuple3 = (15, 10);

            if(tuple1.Equals(tuple2))
            {
                //This is true
            }

            //Coming..//shallow equality
            //if(tuple1==tuple2)
            //{

            //}

        }
    }
}
