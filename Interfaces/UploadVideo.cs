using System;

namespace Interfaces
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Activity: UploadVideo");
        }
    }
}