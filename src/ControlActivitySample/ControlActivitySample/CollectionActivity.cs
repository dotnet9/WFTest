using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace controlActivitySample
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

           context.SetValue (this.myOutCollection,list );
        }
    }
}
