using System;
using System.Collections.Generic;


namespace Feb8thConstructor
{
    public class Customer
    //whenever you have a class and a list inside, initialize the class in an empty lists
    {
        public int Id; //Declaring a field, in real life we woulnd't really do this. default value will be 0
        public string name; //default value will be null
        public readonly List<Order> Orders; //use the list class, take a generic parameter of Order, specifying the type of objects

        public Customer() //parameter less constructor
        {
            Orders = new List<Order>(); //if we do not do this it will initialize order field as an empty list
                                        //whenever we use Customer object
        }

        public Customer(int id)
            : this() //this means when this constructor is called,
                     //it will call constructor without parameters, initializing the order first
        {
            this.Id = id;

        }

        public Customer(int id, string name) //overloading a constructor!
            : this(id) //when we use this constructor, first call constructor that takes the id parameter. 
        {
            this.name = name;
        }

        public void Promote()
        {

        }
    }
}
