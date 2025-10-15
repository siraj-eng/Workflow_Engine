using System;

namespace Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
             var workflow = new WorkFlow();

            workflow.AddActivity(new UploadActivity());
            workflow.AddActivity(new CallCenter());
            workflow.AddActivity(new message());
            workflow.AddActivity(new updateInfo());

            var engine = new WorkFlowEngine();
            engine.Run(workflow);

            Console.ReadLine();
        }
    }
}