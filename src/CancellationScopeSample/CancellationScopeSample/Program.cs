using System;
using System.Activities;

namespace CancellationScopeSample {
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionActivityWorkflow(); //CancellationWorkflow 例子

            parallelCancellationWorkflow();  //ParallelCancellationWorkflow 例子

            System.Console.Read();
        }

        //==============================================================
        static void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            System.Console.WriteLine("完成,实例编号:{0},状态:{1}", e.InstanceId, e.CompletionState.ToString());
        }

        static void aborted(WorkflowApplicationAbortedEventArgs e)
        {
            System.Console.WriteLine("aborted ,实例编号:{1},Reason:{0}", e.Reason.Message, e.InstanceId);
        }
        //==============================================================

        #region //CancellationWorkflow 例子

        static void ExceptionActivityWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new CancellationWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Cancel;
            instance.Aborted = aborted;

            instance.Run();
        }

        static UnhandledExceptionAction unhandledException_Cancel(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException_Cancel:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Cancel;
        }

        #endregion


        #region //ParallelCancellationWorkflow 例子

        static void parallelCancellationWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new ParallelCancellationWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Cancel;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion
    }
}