using System;
using System.Activities;
using System.Collections.Generic;

namespace ArgumentsSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //--------------------------------------
            //-  依次出掉注释,查看不同例子运行结果 -
            //--------------------------------------

            //startValueInWorkflow(); //XAML方式的[In参数]使用

            //InArgumentActivity(); // [In参数]Activity启动

            //InArgumentWorkflow(); //Code方式的[In参数]使用

            //StartValueOutWorkflow(); //XAML方式的[Out参数]使用

            //OutArgumentWorkflow(); //Code方式的[Out参数]使用

            //StartValueInOutWorkflow(); //XAML方式的[In/Out参数]使用

            InOutArgumentWorkflow(); //Code方式的[In/Out参数]使用

            Console.Read();
        }

        private static void startValueInWorkflow()
        {
            var dic =
                new Dictionary<string, object>();
            dic.Add("v1", 123.456);
            dic.Add("v2", 456.789);
            var myInstance = new WorkflowApplication(new StartValueInWorkflow(), dic);

            myInstance.Run();
        }

        private static void InArgumentActivity()
        {
            var dic =
                new Dictionary<string, object>();
            dic.Add("myIn", "wxwinter");

            var myInstance = new WorkflowApplication(new InArgumentActivity(), dic);

            myInstance.Run();
        }

        private static void InArgumentWorkflow()
        {
            var dic =
                new Dictionary<string, object>();
            dic.Add("myValue", "wxwinter wxd");

            var myInstance = new WorkflowApplication(new InArgumentWorkflow(), dic);

            myInstance.Run();
        }


        private static void StartValueOutWorkflow()
        {
            var dic =
                new Dictionary<string, object>();
            dic.Add("v1", 123.456);
            dic.Add("v2", 456.789);
            var myInstance = new WorkflowApplication(new StartValueOutWorkflow(), dic);
            myInstance.Completed = completed;
            myInstance.Run();
        }

        private static void completed(WorkflowApplicationCompletedEventArgs e)
        {
            Console.WriteLine(e.Outputs["v3"].ToString());
        }

        private static void OutArgumentWorkflow()
        {
            var myInstance = new WorkflowApplication(new OutArgumentWorkflow());

            myInstance.Run();
        }


        private static void StartValueInOutWorkflow()
        {
            var dic =
                new Dictionary<string, object>();
            dic.Add("v1", "wxd");
            dic.Add("v2", "lzm");
            dic.Add("v3", "wxwinter");
            var myInstance = new WorkflowApplication(new StartValueInOutWorkflow(), dic);
            myInstance.Completed = completed;
            myInstance.Run();
        }

        private static void InOutArgumentWorkflow()
        {
            var myInstance = new WorkflowApplication(new InOutArgumentWorkflow());

            myInstance.Run();
        }
    }
}