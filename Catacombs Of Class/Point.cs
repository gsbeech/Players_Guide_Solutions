using System;
using System.Collections.Generic;
using System.Text;

namespace Catacombs_Of_Class
{
    class Point
    {
        public float XCoordinate { get; private set; }
        public float YCoordinate { get; private set; }

        public Point(float xCoordinate, float yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public Point()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }
    }
}
