using System.Activities;

namespace ArgumentsSample
{
    public sealed class InOutArgumentActivity : CodeActivity
    {
        public System.Activities.InOutArgument<string> myInOut { set; get; }

        protected override void Execute(CodeActivityContext context)
        {
            //1
            //string s1 = myInOut.Get(context);
            //myInOut.Set(context, "wxd:" + s1);

            //2
            string s2 = context.GetValue(myInOut);
            context.SetValue(myInOut, "wxd:" + s2);
        }
    }
}