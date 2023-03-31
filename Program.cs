using System;

namespace Program
{
    class SuDungToanTu
    {
        static void Main(string[] args)
        {
            float width, height;

            Console.Write("Enter the width: ");
            while (!float.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the width: ");
            }

            Console.Write("Enter the height: ");
            while (!float.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the height: ");
            }

            float area = width * height;
            Console.WriteLine("The area is: " + area);
        }
    }
}

