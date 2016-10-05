using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp6
{
    class NullConditional
    {
        public Action PurchaseCallBack { get; set; }

        public void PurchaseProduct()
        {
            //Store purchase is done, notify caller
            if (PurchaseCallBack != null)
            {
                //Notify the StoreManager we're done with purchase
                //so it can update its UI
                PurchaseCallBack();
            }

            //Now
            PurchaseCallBack?.Invoke();

            string customerInfo = "bip";

            int? length = customerInfo?.Length;

            if (customerInfo?.Length > 0)
            {

            }

            //**** Also see main() for switch ******

            List<string> collection = null;
            var item = collection?[0];
        }
    }
}
