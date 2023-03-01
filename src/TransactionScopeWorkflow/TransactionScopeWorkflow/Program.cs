using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace TransactionScopeWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
           // System.Console.WindowWidth = 120;
           
          //  transactionScopeWorkflow();

          //  transactionTypeWorkflow();

         //   isolationLevelWorkflow();

            rollbackTransactionWorkflow();

            System.Console.Read();

        }

        //=================================================================
        static void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            System.Console.WriteLine("完成,状态:{0}", e.CompletionState.ToString());
        }

        static void aborted(WorkflowApplicationAbortedEventArgs e)
        {
            System.Console.WriteLine("aborted ,Reason:{0}", e.Reason.Message);
        }

        static UnhandledExceptionAction unhandledException(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Abort;
        }
        //=================================================================
        static void  transactionScopeWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new TransactionScopeWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException;
            instance.Aborted = aborted;

            instance.Run();
        }

        static void transactionTypeWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new TransactionTypeWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException;
            instance.Aborted = aborted;

            instance.Run();
        }

        static void isolationLevelWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new IsolationLevelWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException;
            instance.Aborted = aborted;

            instance.Run();
        }

        static void rollbackTransactionWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new rollbackTransactionWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException;
            instance.Aborted = aborted;

            instance.Run();
        }
    }
}
