using System;

namespace DelayAndThreadWorkflow
{
    public class myAsyncResult : IAsyncResult
    {
        public object AsyncState { get; set; }

        public System.Threading.WaitHandle AsyncWaitHandle { get; set; }

        public bool CompletedSynchronously
        {
            get { return true; }
        }

        public bool IsCompleted
        {
            get { return true; }
        }
    }

    public class threadMethod
    {
        AsyncCallback callback;
        IAsyncResult asyncResult;
        int n;
        int result;

        public void myCall(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                result = result + i;
            }

            System.Console.WriteLine("myCall,result:{0}", result);
        }

        public IAsyncResult BeginmyCall(int n, AsyncCallback callback, object asyncState)
        {
            System.Console.WriteLine("BeginmyCall,n:{0}", n);
            this.n = n;
            this.callback = callback;
            this.asyncResult = new myAsyncResult() { AsyncState = asyncState };
            System.Threading.Thread thread =
                new System.Threading.Thread(new System.Threading.ThreadStart(myProcessThread));
            thread.Start();


            return this.asyncResult;
        }

        public void EndmyCall(IAsyncResult r)
        {
            Console.WriteLine("EndmyCall,result:{0}", result);
        }

        public void myProcessThread()
        {
            Console.WriteLine("myProcessThread");
            for (int i = 1; i <= n; i++)
            {
                result = result + i;
                System.Console.WriteLine(i);
                System.Threading.Thread.Sleep(500);
            }

            this.callback(this.asyncResult);
        }
    }
}