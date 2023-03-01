using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokeMethodWorkflow
{
  public   class paramsMethod
    {
      public string myMethod(params string[] list)
      {
          string s = "";
          for (int i = 0; i < list.Length; i++)
          {
              Console.WriteLine(list[i]);
              s = s + list[i];
          }
          return s;
      }
    }
}
