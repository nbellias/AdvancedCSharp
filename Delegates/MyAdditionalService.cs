using System;
namespace Delegates
{
    public class MyAdditionalService
    {
        public MyAdditionalService(int hours, int mins)
        {

        }

        public MyAdditionalService()
        {
            Console.WriteLine("My additional Services with Delegates...");
        }

        public delegate dynamic MyDelegate(dynamic obj);


        public void DoSpecificSomething(int n, MyDelegate callback)
        {
            //TODO: I have to....
            Console.WriteLine(callback);
        }

        public Func<int, int> SquareRoot;

        public Action<List<string>> SortAndPrintNames;
    }
}

