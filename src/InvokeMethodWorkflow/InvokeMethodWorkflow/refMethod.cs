using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokeMethodWorkflow
{
  public  class refMethod
    {
        public void myMethod(int v1, ref int v2)
        {
            v2 = v1 * v2;
        }
    }
}
