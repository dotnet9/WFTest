using System;
using System.Activities;
using System.Activities.Statements;

namespace HelloWorkflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WorkflowInvoker.Invoke(new Workflow1());  // 1、设计器设计流程

            //WorkflowInvoker.Invoke(CreateWorkflowFromCode());   // 2、代码方式生成流程

            var instance = new WorkflowApplication(new Workflow1());
            instance.Completed += WorkflowCompleted;
            Console.WriteLine(instance.Id);
            instance.Run();

            Console.ReadLine();
        }

        static Activity CreateWorkflowFromCode()
        {
            WriteLine writeLine=new WriteLine(){Text = "测试代码创建活动"};
            Sequence sequence = new Sequence();
            sequence.Activities.Add(writeLine);

            return sequence;
        }

        public static void WorkflowCompleted(WorkflowApplicationCompletedEventArgs args)
        {
            Console.WriteLine($"状态：{args.CompletionState.ToString()}");
            Console.WriteLine($"实例编号：{args.InstanceId}");
        }
    }
}