using System;
using System.Collections.Generic;

namespace _038_exercises
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask task in workflow.GetTasks())
            {
                task.Execute();
            }
        }
    }
}
