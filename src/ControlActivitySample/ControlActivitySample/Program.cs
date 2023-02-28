using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace controlActivitySample
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new IfWorkflow());

            WorkflowInvoker.Invoke(new SwitchWorkflow());

            WorkflowInvoker.Invoke(new WhileWorkflow());

            WorkflowInvoker.Invoke(new DoWhileWorkflow());

            WorkflowInvoker.Invoke(new ForEachWorkflow());
          
            System.Console.Read();
        }
    }
}
