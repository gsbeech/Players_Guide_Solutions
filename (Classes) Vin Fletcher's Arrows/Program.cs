using System;

namespace Vin_Fletcher_s_Arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gather user input

            Console.WriteLine("Select a fletching type. (1: Plastic, 2:Turkey Feather, 3: Goose Feather)");

            FletchingType fletchingType = Enum.Parse<FletchingType>(Console.ReadLine());

            Console.WriteLine("Select an arrowhead type. (1: Steel, 2: Wood, 3: Obsidian)");

            ArrowheadType arrowheadType = Enum.Parse<ArrowheadType>(Console.ReadLine());

            Console.WriteLine("Enter a shaft length");

            float shaftLength = float.Parse(Console.ReadLine());

            // Create a new Arrow object

            Arrow userArrow = new Arrow(arrowheadType, fletchingType, shaftLength);

            float arrowCost = userArrow.ArrowCost;
            // Return the cost of the arrow

            Console.WriteLine($"That arrow will cost {arrowCost} gold.");

        }
    }
}
