using System;
using System.Activities;

namespace ExceptionWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WindowWidth = 100;

            //ExceptionActivityWorkflow_None(); //处理Code异常,无[UnhandledExceptionAction]方式例子

            //ExceptionActivityWorkflow_Abort();  //处理Code异常,[UnhandledExceptionAction.Abort]方式例子

            //ExceptionActivityWorkflow_Terminate(); //处理Code异常,[UnhandledExceptionAction.Terminate]方式例子

            //ThrowWorkflow_None(); //处理[Throw Activity]异常,无[UnhandledExceptionAction]方式例子

            //ThrowWorkflow_Abort(); //处理[Throw Activity]异常,[UnhandledExceptionAction.Abort]方式例子

            //ThrowWorkflow_Terminate(); //处理[Throw Activity]异常,[UnhandledExceptionAction.Terminate]方式例子

            //TryCatchWorkflow(); //TryCatch例子

            //rethrowWorkflow(); //Rethrow例子

            TerminateWorkflow(); //TerminateWorkflow例子

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

        #region //处理Code异常,无[UnhandledExceptionAction]方式例子

        static void ExceptionActivityWorkflow_None()
        {
            WorkflowApplication instance = new WorkflowApplication(new ExceptionActivityWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);

            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region //处理Code异常,[UnhandledExceptionAction.Abort]方式例子

        static void ExceptionActivityWorkflow_Abort()
        {
            WorkflowApplication instance = new WorkflowApplication(new ExceptionActivityWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = UnhandledException_Abort;
            instance.Aborted = aborted;

            instance.Run();
        }

        static UnhandledExceptionAction UnhandledException_Abort(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException_Abort:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Abort;
        }

        #endregion

        #region //处理Code异常,[UnhandledExceptionAction.Terminate]方式例子

        static void ExceptionActivityWorkflow_Terminate()
        {
            WorkflowApplication instance = new WorkflowApplication(new ExceptionActivityWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        static UnhandledExceptionAction unhandledException_Terminate(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException_Abort:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Terminate;
        }

        #endregion

        #region //处理[Throw Activity]异常,无[UnhandledExceptionAction]方式例子

        static void ThrowWorkflow_None()
        {
            WorkflowApplication instance = new WorkflowApplication(new ThrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);

            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region //处理[Throw Activity]异常,[UnhandledExceptionAction.Abort]方式例子

        static void ThrowWorkflow_Abort()
        {
            WorkflowApplication instance = new WorkflowApplication(new ThrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = UnhandledException_Abort;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region //处理[Throw Activity]异常,[UnhandledExceptionAction.Terminate]方式例子

        static void ThrowWorkflow_Terminate()
        {
            WorkflowApplication instance = new WorkflowApplication(new ThrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion //TryCatch例子

        #region //TryCatch例子

        static void TryCatchWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new TryCatchWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region //Rethrow例子

        static void rethrowWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new RethrowWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.OnUnhandledException = unhandledException_Terminate;
            instance.Aborted = aborted;

            instance.Run();
        }

        #endregion

        #region //TerminateWorkflow例子

        static void TerminateWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new TerminateWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(terminateWorkflowCompleted);

            instance.Run();
        }

        static void terminateWorkflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            System.Console.WriteLine("完成,实例编号:{0},状态:{1}", e.InstanceId, e.CompletionState.ToString());
            System.Console.WriteLine("Message:{0}", e.TerminationException.Message);
        }

        #endregion
    }
}