using System.Activities;

namespace ControlActivitySample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkflowInvoker.Invoke(new ParallelWorkflow());

            //WorkflowInvoker.Invoke(new ParallelCompletionConditionWorkflow());

            // WorkflowInvoker.Invoke(new ParallelForEachWorkflow());

            WorkflowInvoker.Invoke(new PickWorkflow());
            System.Console.Read();
        }
    }
}