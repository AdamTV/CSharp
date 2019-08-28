using System;

namespace Interfaces
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity: SendEmail");
        }
    }
}