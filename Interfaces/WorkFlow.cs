using System.Collections.Generic;

namespace Interfaces
{
    public class WorkFlow
    {
        public readonly IList<IActivity> Activities;

        public WorkFlow()
        {
            Activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}