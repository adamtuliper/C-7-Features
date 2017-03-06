using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{

    /// <summary>
    /// We can now use accessors, constructors, finalizers
    /// </summary>
    public class OrderProcessor
    {
        private Dictionary<Guid, Order> _orders = new Dictionary<Guid, Order>();

        //Expression bodied constructor
        public OrderProcessor(List<Order> orders) =>  orders.ForEach(o=>  _orders.Add(o.Key, o));

        //Deconstructor / finalizer can support it as well
        ~OrderProcessor() => CleanUpUnmanagedResources();

        private void CleanUpUnmanagedResources()
        {
            //File handles, connections, etc
        }


    }
    public class Order
    {
        public Order()
        {
            Key = Guid.NewGuid();
        }
        public Guid Key { get; private set; }
        public int OrderId { get; private set; }

    }
}
