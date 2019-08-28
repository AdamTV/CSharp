namespace Interfaces
{
    public class WorkFlowEngine
    {
        public static void Run(WorkFlow workFlow)
        {
            foreach (var activity in workFlow.Activities)
            {
                activity.Execute();
            }
        }
    }
}