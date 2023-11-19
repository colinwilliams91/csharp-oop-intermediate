using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine
{
    public static class WorkflowEngine
    {
        public static void Run(Workflow workflow)
        {
            foreach (IActivity activity in workflow.Activities)
            {
                activity.Execute();
            }
        }
    }
}
