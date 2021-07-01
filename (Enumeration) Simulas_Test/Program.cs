using System;

namespace Simulas_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, string, string)[] mealArray = new (string, string, string)[3];
            for (int i = 0; i < mealArray.Length; i++)
            {
                Console.Write($"Please enter the type of meal number {i+1} (1:Soup/2:Stew/3:Gumbo): ");
                var mealType = Console.ReadLine();
                Type thisMealType = (Type)Convert.ToInt32(mealType);

                Console.Write($"Please enter the main ingredient of meal number {i+1} (1:Mushrooms, 2:Chicken, 3:Carrots, 4:Potatoes): ");
                var mainIngredient = Console.ReadLine();
                MainIngredient thisMainIngredient = (MainIngredient)Convert.ToInt32(mainIngredient);

                Console.Write($"Please enter the main ingredient of meal number {i + 1} (1:Spicy, 2:Salty, 3:Sweet): ");
                var seasoning = Console.ReadLine();
                Seasoning thisSeasoning = (Seasoning)Convert.ToInt32(seasoning);
                mealArray[i] = (thisMealType.ToString(), thisMainIngredient.ToString(), thisSeasoning.ToString());
            }

            for (int i = 0; i < mealArray.Length; i++)
            {
                Console.WriteLine($"{mealArray[i].Item3} {mealArray[i].Item2} {mealArray[i].Item1}");
            }
        }
    
        enum Type
        {
            Unknown,
            Soup,
            Stew,
            Gumbo
        }

        enum MainIngredient
        {
            Unknown,
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes
        }

        enum Seasoning
        {
            Unknown,
            Spicy,
            Salty,
            Sweet
        }
    }
}
