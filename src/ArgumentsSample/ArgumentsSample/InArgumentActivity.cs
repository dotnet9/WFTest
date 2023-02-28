using System.Activities;

namespace ArgumentsSample {

    public sealed class InArgumentActivity : CodeActivity
    {
        public System.Activities.InArgument<string> myIn { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string s1 = context.GetValue(this.myIn);
            string s2 = myIn.Get(context);

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);

         }
    }
}
