using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine
{
    public static class WorkflowEngine
    {
        public static void Run(IWorkflow workflow)
        {
            foreach (IActivity activity in workflow.GetTasks())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception)
                {
                    // logging
                    // terminate and persist state of workflow (in db or file) to resume later
                    throw;
                }
            }
        }
    }
}
