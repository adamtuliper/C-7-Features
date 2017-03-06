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


            //Note this is a value on the tuple
            return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                Console.WriteLine($"Calling with {i-1}");
                var (p, pp) = Fib(i - 1);
                Console.WriteLine((p + pp, p));
                return (p + pp, p);
            }
            
        }



        static public void QuickSort(int[] items, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(items, left, right);

                if (pivot > 1)
                    QuickSort(items, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(items, pivot + 1, right);
            }


            int Partition(int[] numbers, int start, int end)
            {
                int pivot = numbers[start];
                while (true)
                {
                    while (numbers[start] < pivot)
                        start++;

                    while (numbers[end] > pivot)
                        end--;

                    if (start < end)
                    {
                        int temp = numbers[end];
                        numbers[end] = numbers[start];
                        numbers[start] = temp;
                    }
                    else
                    {
                        return end;
                    }
                }
            }
        }
    }
}
