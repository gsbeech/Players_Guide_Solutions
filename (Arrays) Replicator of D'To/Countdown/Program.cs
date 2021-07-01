using System;

namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mysquare = new Square();
            mysquare.sidelength = 5;
            Console.WriteLine(mysquare.CalculateArea(mysquare.sidelength));
        }
    }

    class Square
    {
        public int sidelength;
        public int CalculateArea(int sideLength) => sidelength * sidelength;
    }
}
