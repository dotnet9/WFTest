using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace DelayAndThreadWorkflow
{

    public sealed class runtimeTestActivity : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            for (int i = 1; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                System.Console.WriteLine(i);
            }
        }
    }
}
