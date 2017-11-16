using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._2
{
    class in_keyword
    {
        public void Process(in string name)
        {

            // out: we set the argument value to return
            // ref: we can change the argument value passed by ref
            
            // in:  expresses intent that a method won't change it.READONLY

            //Can't send it to anything that has "ref" or "out" either.
            // this fails:   DoSomething(out name);
            Console.WriteLine(name);

            //CS8331 Cannot assign to variable 'in string' because it is a readonly variable 
            //name = "Jane";

        }
    }
}
