using System;

namespace Delegates
{
    public class MyService: IMyService
    {
        public MyService()
        {
            Console.WriteLine("Executing my service...");
        }

        public void StartWithSomething()
        {
            Console.WriteLine("My service: doing something first");
        }

        public bool DoSomethingSecondly()
        {
            return (1 == 1) ? true : false;
        }

        public List<string> SortMyStrings(List<string> lst)
        {
            lst.Sort();
            return lst;
        }
    }
}

