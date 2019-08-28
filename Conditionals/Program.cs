using System;

namespace Conditionals
{
    internal class Program
    {
        private static void Main()
        {
            //1
            Console.Write("Enter a number between 1 and 10: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //2
            Console.Write("Enter a number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            var number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(number2 > number3 ? number2 : number3)} is the bigger number.");

            //3
            Console.Write("Enter a width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(width > height ? "Image is landscape" : "Image is portrait");

            //4
            Console.Write("Enter a speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed of car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demeritPoints = (carSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("{0} demerit points accumulated", demeritPoints);
            }
        }
    }
}