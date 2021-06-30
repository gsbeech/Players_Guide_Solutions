using System;

namespace Replicator_of_D_To
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Please enter an integer to be entered into the array: ");
                var input = Convert.ToInt32(Console.ReadLine());
                firstArray[i] = input;
            }

            int[] secondArray = new int[5];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine($"The value of firstArray at index {i} is {firstArray[i]}");
                Console.WriteLine($"The value of secondArray at index {i} is {secondArray[i]}");
            }
        }
    }
}
