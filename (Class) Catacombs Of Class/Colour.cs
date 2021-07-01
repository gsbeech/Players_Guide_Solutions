using System;
using System.Collections.Generic;
using System.Text;

namespace Catacombs_Of_Class
{
    class Colour
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }

        public Colour(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static Colour CreateWhite => new Colour(255, 255, 255);
        public static Colour CreateBlack => new Colour(0, 0, 0);
        public static Colour CreateRed => new Colour(255, 0, 0);
        public static Colour CreateOrange => new Colour(255, 165, 0);
        public static Colour CreateYellow => new Colour(255, 255, 0);
        public static Colour CreateGreen => new Colour(0, 128, 0);
        public static Colour CreateBlue => new Colour(0, 0, 255);
        public static Colour CreatePurple => new Colour(128, 0, 128);
    }
}
