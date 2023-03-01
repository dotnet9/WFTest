using System;
using System.Activities;

namespace DelayAndThreadWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //delayWorkflow(); //Delay 例子

            //WorkflowInvoker.Invoke(new ThreadSleepParallelWorkflow()); //Parallel是单线程运行的

            //WorkflowInvoker.Invoke(new DelayParallelWorkflow()); //Delay并不是Thread.Sleep

            //workflowApplication(); // WorkflowApplication 例子

            //workflowInvoker(); // WorkflowInvoker 例子

            threadMethodWorkflow();  //	InvokeMethod 异步调用方法例子

            System.Console.Read();
        }

        #region //Delay 例子

        static void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            System.Console.WriteLine("完成,实例编号:{0},状态:{1}", e.InstanceId, e.CompletionState.ToString());
        }

        static void workflowIdle(WorkflowApplicationIdleEventArgs e)
        {
            System.Console.WriteLine("Idle,实例编号:{0}", e.InstanceId);
            foreach (var item in e.Bookmarks)
            {
                System.Console.WriteLine("BookmarkName:{0}", item.BookmarkName);
            }
        }


        static void delayWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new DelayWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);
            instance.Idle = workflowIdle;

            instance.Run();
        }

        #endregion

        #region // WorkflowApplication 例子

        static void workflowApplication()
        {
            WorkflowApplication instance1 = new WorkflowApplication(new runtimeTestWorkflow());
            WorkflowApplication instance2 = new WorkflowApplication(new runtimeTestWorkflow());
            instance1.Run();
            instance2.Run();
        }

        #endregion

        #region // WorkflowInvoker 例子

        static void workflowInvoker()
        {
            WorkflowInvoker.Invoke(new runtimeTestWorkflow());
            WorkflowInvoker.Invoke(new runtimeTestWorkflow());
        }

        #endregion

        #region //	InvokeMethod 异步调用方法例子

        static void threadMethodWorkflow()
        {
            WorkflowApplication instance = new WorkflowApplication(new threadMethodWorkflow());
            instance.Completed = completed;
            instance.Run();
        }

        static void completed(WorkflowApplicationCompletedEventArgs e)
        {
            System.Console.WriteLine("流程完成");
        }

        #endregion
    }
}