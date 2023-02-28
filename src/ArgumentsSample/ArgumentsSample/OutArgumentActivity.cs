using System.Activities;

namespace ArgumentsSample
{
    public sealed class OutArgumentActivity : CodeActivity
    {
        public System.Activities.OutArgument<string> myOut { set; get; }

        protected override void Execute(CodeActivityContext context)
        {
            //1
            string s1 = myOut.Get(context);
            myOut.Set(context, "wxd" + s1);

            //2
            string s2 = context.GetValue(myOut);
            context.SetValue(myOut, "lzm" + s2);
        }
    }
}