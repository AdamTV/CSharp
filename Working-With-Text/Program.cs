using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Working_With_Text
{
    internal class Program
    {
        private static List<int> GetList()
        {
            Console.Write("Enter numbers separated by a hyphen: ");
            var str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)) return new List<int>();
            var words = str.Split('-');
            var numbers = words.Select(t => Convert.ToInt32(t)).ToList();
            return numbers;
        }
        private static void Exercise1()
        {
            var numbers = GetList();
            var isConsecutive = false;
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i + 1] == numbers[i] + 1 || numbers[i + 1] == numbers[i] - 1)
                {
                    isConsecutive = true;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (!isConsecutive) Console.Write("Not ");
            Console.WriteLine("Consecutive");
        }
        private static void Exercise2()
        {
            var numbers = GetList();
            if (numbers.Count < 1) return;
            if (numbers.Count == numbers.Distinct().Count())
                Console.Write("No ");
            Console.WriteLine("Duplicates Exist");
        }
        private static void Exercise3()
        {
            Console.Write("Enter a valid 24h time: ");
            var str = Console.ReadLine();
            try
            {
                var time = DateTime.Parse(str);
                Console.WriteLine(time.ToString("HH:mm is OK!"));
            }
            catch
            {
                Console.WriteLine("Invalid Time!");
            }
        }
        private static void Exercise4()
        {
            Console.Write("Enter a few words separated by a space: ");
            var str = Console.ReadLine();
            var spaces = new List<int>
            {
                0
            };
            if (str == null) return;
            for (var i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                    spaces.Add(i + 1);
            var strBld = new StringBuilder(str.ToLower());
            foreach (var space in spaces)
            {
                strBld[space] -= (char)32;
            }
            strBld.Replace(" ", "");
            Console.WriteLine("CamelCase: " + strBld);
        }
        private static void Exercise5()
        {
            Console.Write("Enter an English word or sentence: ");
            var word = Console.ReadLine();
            if (word == null) return;
            var vowels = word.Count(letter => letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
                                              letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U');
            Console.WriteLine($"{word} has {vowels} vowel(s)");
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
