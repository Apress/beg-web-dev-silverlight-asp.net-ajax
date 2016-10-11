#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

#endregion

namespace SecondWorkflowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WorkflowRuntime workflowRuntime = new WorkflowRuntime())
            {
                AutoResetEvent waitHandle = new AutoResetEvent(false);
                workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) {waitHandle.Set();};
                workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
                {
                    Console.WriteLine(e.Exception.Message);
                    waitHandle.Set();
                };
                Dictionary<string,object> parameters= new Dictionary<string,object>();
                parameters["age"] = 25; // Could replace with args[0] if you like :)

                WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(SecondWorkflowApp.Workflow1),parameters);
                
                instance.Start();
                

                waitHandle.WaitOne();
            }
        }
    }
}
