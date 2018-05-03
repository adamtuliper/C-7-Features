using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7._3
{

//New "unmanaged" word as a constraint.
//A type MUST be a struct and ALL fields must be one of:
// sbyte, byte, short, ushort, int, uint, long, 
// ulong, char, float, double, decimal, bool, IntPtr or UIntPtr.
// enum, pointer


// Unmanaged type
struct Point { 
    int X;
    int Y {get; set;}
}

// Not an unmanaged type
struct Student { 
    string FirstName;
    string LastName;
}

#if CSharp_73
    class unmanaged_type_constraint
    {     

        public void RunMe()
        {

            Hash(new Point()); // Meets criteria 
            Hash(42); // Same
            Hash("hello") // Error: Type string does not satisfy the unmanaged constraint
        }


        void Hash<T>(T value) where T : unmanaged
        {
            // Okay (note we're not marked unsafe on the method)
            //prevent GC from relocating variable.
            fixed (T* p = &value) { 
                //
            }
        }
    }
#endif
}
