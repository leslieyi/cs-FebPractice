using System;


namespace Feb8thConstructor
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();//this will re-initializes the orders field.
                               //so we need to do read only  

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
