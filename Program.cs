using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Decision_Structures_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, hurricane, randomInt, chosenInt;
            Random generator = new Random();
            Console.WriteLine("Stages");
            Console.WriteLine("Please enter your age");
            if (Int32.TryParse(Console.ReadLine(), out age) == true)
                if (age >= 18)
                    Console.WriteLine("Adult");
                else if (age < 0)
                    Console.WriteLine("Please enter a positive value");
                else if (age <= 5)
                    Console.WriteLine("Toddler");
                else if (age <= 10)
                    Console.WriteLine("Child");
                else 
                    Console.WriteLine("Teen");
            else
                Console.WriteLine("User error: non-number used");
            Console.WriteLine("");
            Console.WriteLine("Hurricane");
            Console.WriteLine("Please enter a number between 1 and 5");
            if (Int32.TryParse(Console.ReadLine(), out hurricane) == true)
                switch (hurricane)
                {
                    case 1:
                        Console.WriteLine("The speed of a category 1 hurricane is between 119 and 153 KM per Hour");
                        break;
                    case 2:
                        Console.WriteLine("The speed of a category 2 hurricane is between 154 and 177 KM per Hour");
                        break;
                    case 3:
                        Console.WriteLine("The speed of a category 3 hurricane is between 178 and 209 KM per Hour");
                        break;
                    case 4:
                        Console.WriteLine("The speed of a category 4 hurricane is between 210 and 249 KM per Hour");
                        break;
                    case 5:
                        Console.WriteLine("The speed of a category 5 hurricane is 250 or more KM per hour");
                        break;
                }
            else
                Console.WriteLine("User error: proper number not found.");
            Console.WriteLine("");
            Console.WriteLine("Random Divisible");
            randomInt = generator.Next(2, 7);
            Console.WriteLine("Please enter a number larger than " + randomInt);
            if (Int32.TryParse(Console.ReadLine(), out chosenInt) == true)
                if (chosenInt > randomInt)
                    if (chosenInt % randomInt == 0)
                        Console.WriteLine("Divisible");
                    else
                        Console.WriteLine("Not Divisible");
                else
                    Console.WriteLine("Error: number Smaller than the divisor");
            else
                Console.WriteLine("Error: Non Numeric value used");

        }
    }
}
