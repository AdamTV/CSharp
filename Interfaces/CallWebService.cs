using System;

namespace Interfaces
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity: CallWebService");
        }
    }
}