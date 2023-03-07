using System;
namespace Delegates
{
    public interface IMyService
    {
        public void StartWithSomething();
        public bool DoSomethingSecondly();
        public List<string> SortMyStrings(List<string> myList);
    }
}

