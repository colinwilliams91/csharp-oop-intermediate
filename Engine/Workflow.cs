using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine
{
    public class Workflow : IWorkflow
    {
        private List<IActivity> _activities;

        public Workflow()
        {
            // if we accept a List<IActivity> as ctor arg we want to check for null
            //if (activities == null)
            //    throw new ArgumentNullException("Cannot instantiate Workflow. Workflow activities empty.");

            //this.Activities = activities;
            this._activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            this._activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            this._activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetTasks()
        {
            return this._activities;
        }
    }
}
