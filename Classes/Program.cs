using System;

namespace Classes
{
    internal class Program
    {
        private static void Main()
        {
            var watch = new Stopwatch();
            for (var i = 0; i < 3; i++)
            {
                watch.Start();
                System.Threading.Thread.Sleep(100);
                watch.Stop();
            }

            var post = new Post("First Post", "Adam is the best");
            try
            {
                post.VoteDown();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            for(var i = 0; i < 1000; i++)
                post.VoteUp();
            post.Display();
        }
    }
}
