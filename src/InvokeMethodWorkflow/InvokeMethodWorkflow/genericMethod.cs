namespace InvokeMethodWorkflow {
    public   class genericMethod
    {
      public int myMethod<T1, T2>(T1 v1, T2 v2)
      {
          int n1 = int.Parse(v1.ToString());
          int n2 = int.Parse(v2.ToString());
          return n1 +n2;
      }
    }
}
