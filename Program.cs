using c_sharp_7.CSharp6;
using c_sharp_7.CSharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7
{
    public class Program
    {
        public class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            var nullConditional = new NullConditional();
            nullConditional.PurchaseProduct();

            //Binary Literal
            DigitAndBinary.Process();
            Task t = Tupler.Process();
            t.Wait();

            //Literals
            var (a, b, c, c1, c2) = (1, 2, 3, 4, 5);

            
            //Console.WriteLine($"{results.Item2}");
            var result = a + b + c;

            //Deconstruction
            var point = new Point(5, 4);
            var (p1, p2) = point;





            (float i, int j, int k) = (1, 2, 3);
            var (p, q, r) = new(int b1, int b2, int b3) { b1 = 2, b2 = 3, b3 = 4 };
            //Names don't matter
            (int x, int y, int z) = new(int b1, int b2, int b3) { b1 = 2, b2 = 3, b3 = 4 };

            var speedAndHealth = new(int speed, int health) { health = 100, speed = 10 };

            var someFloats = (1f, 3.4f);

            var newTup = new(int b1, int b2, int b3) { b1 = 2, b2 = 3, b3 = 4 };
            //can't convert
            //(string d, string e, string f) = new(int b1, int b2, int b3) { b1 = 2, b2 = 3, b3 = 4 };

            var item = (num: 1f, count: 2f, name: "hello", person: new Person() { Name = "Adam" });
            item.Item1 = item.Item2 * item.Item1;

            OutVars.Process();

            //var exceptionFilter = new ExceptionFilters();
            //exceptionFilter.Process();

            //Real null conditional
            switch (args?.Length)
            {
                case 1:
                    //one arg passed in
                    break;
            }

       

            //Ref returns
            var refReturns = new RefReturnsAndOuts();
            refReturns.TestRefs();

            // *****   Pattern matching 
            var patternMatching = new PatternMatching();
            patternMatching.MatchSomething(new Rectangle() { Height = 5, Length = 4 });

            //Int
            patternMatching.PrintStars(5);

            //String
            patternMatching.PrintStars("5");

            //Shape
            patternMatching.PrintStars(new Rectangle());




        }
    }
}
