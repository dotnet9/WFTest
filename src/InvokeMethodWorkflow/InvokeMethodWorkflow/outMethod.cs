using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokeMethodWorkflow
{
  public  class outMethod
    {
      public void myMethod(int v1, out int v2)
      {
          v2 = v1  * 10;
      }
    }
}
