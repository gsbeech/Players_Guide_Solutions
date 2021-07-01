using System;

namespace War_Preparations
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword basicSword = new Sword(Material.Iron, Gemstone.None, 100.0F, 50.0F);

            // As records are immutable, you cannot change the first object, but can use it as a template for a new object, specifying different property values using "with"
            Sword enhancedSword = basicSword with { Material = Material.Steel, Decoration = Gemstone.Emerald };
            Sword bestSword = enhancedSword with { Material = Material.Binarium, Decoration = Gemstone.Bitstone };

            // The compiler provides automatic, useful overrides for the default ToString properties
            Console.WriteLine(basicSword.ToString());
            Console.WriteLine(enhancedSword.ToString());
            Console.WriteLine(bestSword.ToString());
        }
    }
}
