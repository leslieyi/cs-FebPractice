using System;
using System.Collections.Generic;

namespace Feb8thFields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders = new List<Order>(); // we need to initialize this list, as an empty list
                                                       // an interesting approach as opposed to the bottom.
                                                       // Just be consistent with your approach to keep the code clean. 

        //public Customer()
        //{
        //    Orders = new List<Order>();//there is a problem, bc we need to call this first, to call ID and Name. 
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List
            //
        }
    }

}
