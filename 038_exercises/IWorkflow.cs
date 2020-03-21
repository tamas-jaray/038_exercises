using System.Collections.Generic;

namespace _038_exercises
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
