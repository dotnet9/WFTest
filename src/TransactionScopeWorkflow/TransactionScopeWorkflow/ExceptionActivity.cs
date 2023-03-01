using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace TransactionScopeWorkflow
{

    public sealed class ExceptionActivity : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            int v = 1 - 1;
            double i = 1 / v;
        }
    }
}
