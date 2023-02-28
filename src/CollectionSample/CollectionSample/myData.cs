namespace CollectionSample
{
    public class myData
    {
        public string myValue { set; get; }
    }

    public class myDataComparer : System.Collections.Generic.IComparer<myData>
    {
        public int Compare(myData x, myData y)
        {
            if (x.myValue == y.myValue)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}