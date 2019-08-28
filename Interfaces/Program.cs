namespace Interfaces
{
    internal class Program
    {
        private static void Main()
        {
            var workFlow = new WorkFlow();
            workFlow.AddActivity(new UploadVideo());
            workFlow.AddActivity(new CallWebService());
            workFlow.AddActivity(new SendEmail());
            workFlow.AddActivity(new ChangeVideoStatus());
            WorkFlowEngine.Run(workFlow);
        }
    }
}
