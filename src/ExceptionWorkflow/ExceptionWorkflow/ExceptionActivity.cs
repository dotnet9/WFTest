using System.Activities;

namespace ExceptionWorkflow {

    public sealed class ExceptionActivity : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            var v = 1 -1;
            _ = 1 / v;
        }
    }
}
