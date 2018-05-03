using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    class Discards
    {
        public void ShowMeDiscards()
        {
            object q=null;
            var (_,y,z) = (1,2,3);

            //Error
            //OutArgExample(out int x, out int x);
            
            //OK
            OutArgExample(out int _, out int _);
            
            //Simplified
            OutArgExample(out _, out _);

            if(q is int )
            {

            }
        }

        void OutArgExample(out int number, out int status)
        {
            number = 44;
            status = 10;
        }
    }
}
