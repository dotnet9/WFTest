using System;
using System.Activities;

namespace VariablesAndArgumentsSample
{
    public sealed class InChangeActivity : CodeActivity
    {
        public InArgument<string> myIn { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string s1 = context.GetValue(this.myIn);

            System.Console.WriteLine("传入值为:{0}", s1);

            //
            context.SetValue(myIn, Guid.NewGuid().ToString());

            //
            string s2 = context.GetValue(this.myIn);

            System.Console.WriteLine("内部修改:{0}", s2);
        }
    }
}