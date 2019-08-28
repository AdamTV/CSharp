using System;

namespace Interfaces
{
    public class ChangeVideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity: ChangeVideoStatus");
        }
    }
}