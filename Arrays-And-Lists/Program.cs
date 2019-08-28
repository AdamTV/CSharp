using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_And_Lists
{
    internal class Program
    {
        private static void Exercise1()
        {
            var names = new List<string>();
            Console.WriteLine("Enter different names, press Enter to continue:");
            while (true)
            {
                var temp = Console.ReadLine();
                if (temp == "")
                    break;
                names.Add(temp);
            }

            switch (names.Count)
            {
                case 1:
                    Console.WriteLine($"{names[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                    break;
                default:
                    {
                        if (names.Count > 2)
                            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
                        break;
                    }
            }
        }
        private static void Exercise2()
        {
            Console.Write("Enter a name: ");
            var name = Console.ReadLine();

            if (name == null) return;

            // convert to char array to reverse
            var reverse = new char[name.Length];
            for (var i = 0; i < name.Length; i++)
                reverse[i] = name[i];
            Array.Reverse(reverse);
            // convert back to string to output
            var reversed = new string(reverse);
            Console.WriteLine($"Name reversed is: {reversed}");

        }
        private static void Exercise3()
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter 5 unique numbers separated by pressing Enter: ");
            while (numbers.Count < 5)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                    Console.WriteLine("Number already entered!");
                else
                    numbers.Add(number);
            }
            numbers.Sort();
            Console.WriteLine();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        private static void Exercise4()
        {
            var numbers = new List<int>();
            Console.WriteLine("Continuously enter a number or type Quit to exit");
            while (true)
            {
                var number = Console.ReadLine();
                if (number == "Quit") break;
                numbers.Add(Convert.ToInt32(number));
            }

            var uniques = new List<int>();

            foreach (var number in numbers.Where(number => !uniques.Contains(number)))
            {
                uniques.Add(number);
            }

            Console.Write("Unique numbers are: ");
            foreach (var number in uniques)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        private static void Exercise5()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Write a comma separated list of at least 5 numbers: ");
                var str = Console.ReadLine();
                if (str == null) return;
                var list = str.Split(',');
                numbers = list.Select(number => Convert.ToInt32(number)).ToList();
                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid list, please retry.");
                }
                else
                {
                    var smallest = new List<int>();
                    for (var i = 0; i < numbers.Count; i++)
                    {
                        if (numbers.Contains(i))
                            smallest.Add(i);
                        if (smallest.Count > 2)
                            break;
                    }

                    Console.Write("The three smallest values are: ");
                    foreach (var number in smallest)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
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
