using System.Activities;

namespace InvokeMethodWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // WorkflowInvoker.Invoke(new ClassMethodWorkflow());
            //
            //WorkflowInvoker.Invoke(new instanceMethodWorkflow());
            //
            WorkflowInvoker.Invoke(new paramsMethodWorkflow());
            //
            // WorkflowInvoker.Invoke(new outMethodWorkflow());
            //
            // WorkflowInvoker.Invoke(new refMethodWorkflow());
            //
            // WorkflowInvoker.Invoke(new genericMethodWorkflow());


            System.Console.Read();
        }
    }
}