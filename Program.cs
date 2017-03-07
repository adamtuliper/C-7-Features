using c_sharp_7.Charp6;
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

            //Review 1 Null Conditional
            var nullConditional = new NullConditional();
            nullConditional.PurchaseProduct();

            //nifty was of checking argument length
            switch (args?.Length)
            {
                case 1:
                    //one arg passed in
                    break;
                case 2:
                    //you get the idea
                    break;
            }


            //2 Interpolation
            Interpolation.InterpolateDemo();


            //3 Null conditional
            var nc = new NullConditional();
            nc.PurchaseProduct();

            //As you see fit...



            //*****************************************************
            //1. Binary Literal
            DigitAndBinary.Process();
            
            //*****************************************************
            //2. Ref returns 
            var refReturns = new RefReturnsAndOuts();
            refReturns.TestRefs();
            
            //*****************************************************
            //3. Expression bodied accessors, constructors, destructor/finalizer
            //3A. C# 6 
            var zombie = new CSharp6.ExpressionBodied6.Zombie("Fred", 30);
            Console.WriteLine(zombie.ToString());

            //3B. Note C#6 collection initialization
            List<Order> orders = new List<Order>() { new Order(), new Order(), new Order() };
            var processor = new OrderProcessor(orders);

            //*****************************************************
            //4. Throw expressions
            try
            {
                var person = new CSharp7.Person(null);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Caught throw expression:{ex}");
            }

            //*****************************************************
            //5. Local Functions
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            LocalFunctions.QuickSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("Sorted items");
            numbers.ToList().ForEach(o => Console.WriteLine(o));

            //Ex 2
            LocalFunctions.Fibonacci(5);


            //*****************************************************
            //6. Out vars
            OutVars.Process();

            //*****************************************************
            //7. Pattern Matching

            var pm = new PatternMatching();
            pm.MatchSomething(new Circle(3.5d));
            pm.MatchSomething(new Rectangle(2d, 4d));


            //Int
            pm.PrintStars(5);

            //String
            pm.PrintStars("5");

            //Shape
            pm.PrintStars(new Rectangle(3,4));


            //*****************************************************
            //8. Tuples
            var t = Tupler.ProcessLanguage();
            t.Wait();

            var result = t.Result;
            Console.WriteLine($"{result.keyPhrases}\r\n{result.sentiment}\r\n{result.language}");

            //Literals
            var (a, b, c, c1, c2) = (1, 2, 3, 4, 5);


            //Console.WriteLine($"{results.Item2}");
            var addThemUp = a + b + c;

            //Types and values
            (float i, int j, int k) = (1, 2, 3);
            (int p, int q, int r) theTup = (2, 3, 4);

            var stats = (age:100, health:100, iq:100);

            //mutable
            theTup = (5, 6, 7);
            theTup.p = 8;


            //Names don't matter
            (string, string, string) stringTuple = default((string tup1, string tup2, string tup3));

            //type inference
            var someFloats = (1f, 3.4f);

            //named type inference
            var speedAndHealth = (health: 100, speed: 10);

            (int b1, int b2, int b3) intTup = (2, 3, 4);
            //can't convert dbl to float, and also a:1 - 'a' will be ignored
            //(int a1, float b1, int c20) conversions = (a: 1, 2d, 3);

            var item = (num: 1f, count: 2f, name: "hello", person: new Person() { Name = "Adam" });
            item.Item1 = item.Item2 * item.Item1;


            //8b. Deconstruction
            var point = new Point(5, 4);
            var (p1, p2) = point;


        }
    }
}
