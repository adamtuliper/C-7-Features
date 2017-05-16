using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._1
{
    class discards_in_lambdas
    {
        public void Run()
        {
            //contrived example
            //we can currently do this. _ is treated as variable name - its a convention
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            int counter = 0;
            //This works, its valid
            //var _ = 600;

            list.ForEach(_ => { counter++; });

            //Now multiple _ in lambdas meaning truly "I dont care"
            //Func<int, int, int> zero = (_, _) => 0;
        }
    }
}
