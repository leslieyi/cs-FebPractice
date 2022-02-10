using System;

namespace Feb8thMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var num = int.Parse("ABC");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conversion of num Failed");

            }

            int number; //need to declare it separately, and use out, if not use the above. 
            var result = int.TryParse("abc", out number); //this does not throw an exception. 
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion of Number Failed");

        }

        static void UseParams()
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));

        }


        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");


                point.Move(100, 200);
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");

            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error ocurred!");
            }
        }



    }
}

