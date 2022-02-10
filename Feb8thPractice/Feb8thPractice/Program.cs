using System;

namespace Feb8thPractice
{
    public class Person
    {
        public string Name; //member field, like a variable. attached to the class Person. 

        public void Introduce(string to) //instance method, need to be instantiated prior to usage. 
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
            //format string, parameters that we will fill up.
            //First one is filled with the to argument,
            //and second one is going to be the name field stored in the class!


        }

        public static Person Parse(string str)//Parse Method: create a person obj, based on the str argument 
        {
            var person = new Person(); //make a person Object
            person.Name = str; //set the name field based on the str field

            return person; //return that person

        }
    }
    class Program
    {
        static void Main(string[] args) //static method, used without instantiating. 
        {
            //if we want to use Parse method, we need to use it in an obj, bc it's an instance method
            var person = Person.Parse("a computer program!");

            person.Introduce("Leslie");//Calling the introduce method with an argument of "Leslie"
        }
    }
}
