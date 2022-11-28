// See https://aka.ms/new-console-template for more information
using Delegates;

List<string> myList = new List<string>() { "Nikos", "Margarita", "Spyros", "Iris", "Sofia" };

Console.WriteLine("---Interfaces---");
MyService mySvc = new MyService();
mySvc.StartWithSomething();
Console.WriteLine($"Second is {mySvc.DoSomethingSecondly()}");
Console.WriteLine($"The list is sorted: {String.Join(',', mySvc.SortMyStrings(myList))}");
Console.WriteLine();

Console.WriteLine("---Delegates---");
MyAdditionalService myAddSvc = new MyAdditionalService();
myAddSvc.DoSpecificSomething(3, (ο) => new { oid = 3 });

//Dynamically extending sortAndPrintNames
myAddSvc.SortAndPrintNames = (lst) =>
{
    lst.Sort();
    Console.WriteLine(String.Join(',', lst));
};
myAddSvc.SortAndPrintNames(myList);