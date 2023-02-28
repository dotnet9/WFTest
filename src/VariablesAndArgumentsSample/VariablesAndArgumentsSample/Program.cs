using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace VariablesAndArgumentsSample
{

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("InChangeWorkflow");
            WorkflowInvoker.Invoke(new InChangeWorkflow());
            System.Console.WriteLine("=================================\r");


            System.Console.WriteLine("OutChangeWorkflow");
            WorkflowInvoker.Invoke(new OutChangeWorkflow());
            System.Console.WriteLine("=================================\r");


            System.Console.WriteLine("InOutChangeWorkflow");
            WorkflowInvoker.Invoke(new InOutChangeWorkflow());
            System.Console.WriteLine("=================================\r");





           System.Console.Read();
        }
    }
}
