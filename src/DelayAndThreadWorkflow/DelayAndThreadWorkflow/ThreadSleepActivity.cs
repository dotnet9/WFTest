using System.Activities;

namespace DelayAndThreadWorkflow {

    public sealed class ThreadSleepActivity : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            System.Threading.Thread.Sleep(10000);
        }
    }
}
