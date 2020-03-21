using System;

namespace _038_exercises
{
    public class ChangeStatusInDbToProcessing : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing the status to Processing in the DB");
        }
    }
}
