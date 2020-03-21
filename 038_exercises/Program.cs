using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new VideoDecoder());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeStatusInDbToProcessing());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
            

        }
    }
}
