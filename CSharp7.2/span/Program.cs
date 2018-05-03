using System;
using System.Runtime.InteropServices;

namespace span
{
    class Program
    {
        static void Main(string[] args)
        {

            string contentLength = "content-length:123";

            //WARNING:  Install-Package System.Memory -Version 4.5.0-preview1-26216-02
            //As of 7.2 package is included automatically (No System.Memory required, though earlier versions need it)

            int length = int.Parse(contentLength.Substring(15)); // this allocates
            var output = contentLength.AsReadOnlySpan().Slice(15);
            Console.WriteLine("Hello World!");


            ///Fixed record processing
            string name = "MARY      DOE       ";
            var span = name.AsReadOnlySpan();
            string firstNameAlloc = name.Substring(startIndex: 0, length: 10); // Allocates 

            var firstNameBytes = span.Slice(start: 0, length: 10); // No allocation

            //COMING
            //firstNameString = firstName.ToString();
            //firstName[0] = 'a'; // Error CS0200: indexer cannot be assigned to



            //Unsafe operations
            IntPtr ptr = Marshal.AllocHGlobal(1);
            try
            {
                Span<byte> bytes;
                unsafe { bytes = new Span<byte>((byte*)ptr, 1); }
                bytes[0] = 42;
                bytes[1] = 43; // Throws IndexOutOfRangeException
            }
            finally { Marshal.FreeHGlobal(ptr); }


        }
    }
}
