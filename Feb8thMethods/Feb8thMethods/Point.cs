using System;
namespace Feb8thMethods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            //DEFENSIVE PROGRAMMING
            //exception is just a class. we are instantiating the class
            //if new location is null, we will never reach the next line,
            //x and y will never change, and remain valid!

            Move(newLocation.X, newLocation.Y);
        }

    }
}

