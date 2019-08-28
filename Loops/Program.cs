using System;
using System.Linq;

namespace Loops
{
    internal class Program
    {
        // 1
        private static void Exercise1()
        {
            var divisibleBy3 = 0;
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    divisibleBy3++;
            }
            Console.WriteLine($"{divisibleBy3} numbers are divisible by 3 with no remainder between 1 and 100");
        }

        // 2
        private static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or \"ok\" to exit: ");
                var temp = Console.ReadLine();
                if (temp == "ok")
                    break;
                sum += Convert.ToInt32(temp);
            }
            Console.WriteLine($"The sum of the numbers entered is: {sum}");
        }

        // 3
        private static void Exercise3()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = number;
            for (var i = number - 1; i > 0; i--)
                factorial *= i;
            Console.WriteLine($"{number}! = {factorial}");
        }

        // 4
        private static void Exercise4()
        {
            var rand = new Random();
            var randNum = rand.Next(10);
            //Console.WriteLine(randNum);
            Console.Write("You have 4 chances to guess the number between 1 and 10: ");
            for (var i = 4; i > 0; i--)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randNum)
                { 
                    Console.WriteLine("You won!");
                    break;
                }
                Console.Write(i > 1 ? $"Try again! You have {i - 1} guesses remaining: " : "You Lost!\n");
            }
        }

        // 5
        private static void Exercise5()
        {
            Console.Write("Enter a series of number separated by a comma.\n");
            var text = Console.ReadLine();
            if (text == null) return;
            // split entered string into string array of numbers only
            var numbersStr = text.Split(',');
            var numbers = new int[numbersStr.Length];
            // copy values from string array into int array
            for (var i = 0; i < numbersStr.Length; i++)
                numbers[i] = Convert.ToInt32(numbersStr[i]);
            // find max value of numbers array using LINQ-expression
            var max = numbers.Concat(new[] {0}).Max();
            Console.WriteLine($"The maximum number entered was {max}");
        }

        private static void Main()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }
    }
}
