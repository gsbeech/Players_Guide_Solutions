using System;

namespace Room_Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate firstCoord = new Coordinate(1, 1);
            Coordinate secondCoord = new Coordinate(1, 2);
            Console.WriteLine(Coordinate.AreAdjacent(firstCoord, secondCoord));

        }
    }
}
