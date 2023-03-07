// See https://aka.ms/new-console-template for more information
using AsynchronousProgramming;
using AsynchronousProgramming.Models;

Console.WriteLine("...Asynchronous Programming...");
Console.WriteLine("-------------------------------");
Console.WriteLine();

SimpleParallelInvoke();

int[] items = ParallelForEachInvoke();

ParallelForInvokeWithControlling(items);

List<Employee> employees = SimpleParallelLINQ();

ParallelLINQWithExtras(employees);

AsyncAndAwait();

Console.WriteLine("Finished processing. Press a key to end.");
Console.ReadKey();

//Methods follow
static void SimpleParallelInvoke()
{
    Console.WriteLine("...Simple Parallel Invoke...");
    Parallel.Invoke(() => MyServiceTasks.SvcTask1(), () => MyServiceTasks.SvcTask2());
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
}

static int[] ParallelForEachInvoke()
{
    Console.WriteLine("...Parallel ForEach...");
    var items = Enumerable.Range(0, 500).ToArray();
    Parallel.ForEach(items, item =>
    {
        MyServiceTasks.SvcWorkOnItem(item);
    });
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
    return items;
}

static void ParallelForInvokeWithControlling(int[] items)
{
    Console.WriteLine("...Parallel For with ParallelLoopResult control...");
    ParallelLoopResult result = Parallel.For(0, items.Count(),
        (int i, ParallelLoopState loopState) =>
        {
            if (i == 200)
                loopState.Stop();
            MyServiceTasks.SvcWorkOnItem(items[i]);
        });
    Console.WriteLine("Completed: " + result.IsCompleted);
    Console.WriteLine("Items: " + result.LowestBreakIteration);
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
}

static List<Employee> SimpleParallelLINQ()
{
    Console.WriteLine("...Simple Parallel LINQ...");
    var employees = Employee.GetAllEmployees();
    var employeesInITDepartment = from employee in employees.AsParallel()
                                  where employee.Department == "IT"
                                  select employee;
    foreach (var employee in employeesInITDepartment)
        Console.WriteLine(employee.Name);
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
    return employees;
}

static void ParallelLINQWithExtras(List<Employee> employees)
{
    Console.WriteLine("...Parallel LINQ with the query executed on a max of 4 processors...");
    var employeesInITDepartmentAndCityLondon = from employee in employees.AsParallel().
                                  WithDegreeOfParallelism(4).
                                  WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                                               where employee.Department == "IT" &
                                                     employee.City == "London"
                                               select employee;
    foreach (var employee in employeesInITDepartmentAndCityLondon)
        Console.WriteLine(employee.Name);
    Console.WriteLine("-------------------------------");
    Console.WriteLine();

    //Check also the following which would slow down the query
    //var employeesInITDepartmentAndCityLondon = from employee in employees.AsParallel().
    //                                           AsOrdered()
    //                                           where employee.Department == "IT" &
    //                                                 employee.City == "London"
    //                                           select employee;
    //
    //var employeesInITDepartmentAndCityLondon = (from employee in employees.AsParallel()
    //                                           where employee.Department == "IT" &
    //                                                 employee.City == "London"
    //                                           select new
    //                                           {
    //                                               Name = employee.Name
    //                                           }).AsSequential().Take(1);
}

static void AsyncAndAwait()
{
    Console.WriteLine("...Async and Await...");
    MyServiceTasks myServiceTasks = new MyServiceTasks();
    myServiceTasks.SvcLongTask("1000000000");
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
}