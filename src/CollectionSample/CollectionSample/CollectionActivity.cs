using System.Activities;
using System.Collections.Generic;

namespace CollectionSample
{
    public sealed class CollectionActivity : CodeActivity
    {
        public OutArgument<System.Collections.Generic.List<string>> myOutCollection { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            System.Collections.Generic.List<string> list = new List<string>();
            list.Add("wxd");
            list.Add("lzm");
            list.Add("wxwinter");

            context.SetValue(this.myOutCollection, list);
        }
    }
}