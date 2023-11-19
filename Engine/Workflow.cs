using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine
{
    public class Workflow
    {
        private List<IActivity> _activities;

        public Workflow(List<IActivity> activities)
        {
            if (activities == null)
                throw new ArgumentNullException("Cannot instantiate Workflow. Workflow activities empty.");

            this.Activities = activities;
        }

        public List<IActivity> Activities { get => _activities; set => _activities = value; }
    }
}
