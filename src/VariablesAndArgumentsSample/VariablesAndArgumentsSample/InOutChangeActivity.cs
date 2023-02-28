using System;
using System.Activities;

namespace VariablesAndArgumentsSample
{
    public sealed class InOutChangeActivity : CodeActivity
    {
        public InOutArgument<string> myInOut { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string s1 = context.GetValue(this.myInOut);
            System.Console.WriteLine("传入值为:{0}", s1);

            //
            context.SetValue(myInOut, Guid.NewGuid().ToString());

            //
            string s2 = context.GetValue(this.myInOut);
            System.Console.WriteLine("内部修改:{0}", s2);
        }
    }
}