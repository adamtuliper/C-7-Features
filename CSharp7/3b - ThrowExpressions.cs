using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    public class Person
    {

        public string Name { get; }

        //Previously we didn't support throwing exceptions on expression bodied items.
        public Person(string name) => Name = name ?? throw new ArgumentNullException(name);

        public string GetFirstName()
        {
            var parts = Name.Split(' ');
            return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
        }
        public string GetLastName()  => throw new NotImplementedException();

    }
}
