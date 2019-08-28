using System;
using System.IO;
using System.Linq;

namespace Files
{
    internal class Program
    {
        private static string FileParser()
        {
            Console.Write("Enter name of file: ");
            var fileName = Console.ReadLine();
            var path = @"C:\Users\adams\source\repos\C#\Files\" + fileName;
            if (!File.Exists(path)) return "";
            var contents = File.ReadAllText(path);
            return contents;
        }
        private static void WordCounter()
        {
            var contents = FileParser();
            int size = 0, words = 0;
            while (size < contents.Length)
            {
                if (contents[size] == ' ' || contents[size] == '\n' || contents[size] == '\t')
                    words++;
                size++;
            }
            Console.WriteLine($"Number of words in file: {words}");
        }

        private static void LongestWord()
        {
            var contents = FileParser();
            var words = contents.Split(' ', '\n', '\r');
            var size = words.Select(word => word.Length).Concat(new[] {0}).Max();
            Console.WriteLine($"Length of longest word is {size} characters.");
        }
        private static void Main()
        {
            WordCounter();
            LongestWord();
        }
    }
}
