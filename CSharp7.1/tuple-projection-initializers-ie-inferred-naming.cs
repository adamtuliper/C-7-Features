using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._1
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    class tuple_projection_initializers_ie_inferred_naming
    {
        internal class bip
        {
            public int f1;
            public int f2;
        }

        void Run()
        {
            //Inferred naming
            var x1 = new bip();

            var tuple = ((x1.f1, x1.f2) = (1, 2));


            //inferred naming without (f1:x1.f1, f2:x1.f2)
            tuple.f1 = tuple.f2;

            Person p = new Person()
            {
                Name = "Mary",
                Age = 52,
                Address = "555 Main St",
                City = "Bethlehem",
                State = "PA"
            };

            //Note, no longer Item1 Item2
            var shortened = (p.Name, p.Address);
            Console.WriteLine( $"{shortened.Name} {shortened.Address}");
        }
    }
}
