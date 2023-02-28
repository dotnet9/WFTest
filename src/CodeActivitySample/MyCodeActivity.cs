using System;
using System.Activities;

namespace CodeActivitySample
{
    public sealed class MyCodeActivity : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            Console.WriteLine("请输入内容：");
            var inputString = Console.ReadLine();
            
            Console.WriteLine($"您输入的是：{inputString}");
        }
    }
}