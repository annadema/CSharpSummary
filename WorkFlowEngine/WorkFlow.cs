using System.Collections.Generic;

namespace WorkFlowEngine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly IList<IActivity> _activityList;

        public WorkFlow()
        {
            _activityList = new List<IActivity>();
        }


        public void Add(IActivity activity)
        {
            _activityList.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activityList.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activityList;
        }
    }
}