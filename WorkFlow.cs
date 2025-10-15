using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class WorkFlow
    {
        private readonly List<Iactivity> _activities;

        public WorkFlow()
        {
            _activities = new List<Iactivity>();
        }

        public void AddActivity(Iactivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<Iactivity> GetActivities()
        {
            return _activities;
        }
    }
}
