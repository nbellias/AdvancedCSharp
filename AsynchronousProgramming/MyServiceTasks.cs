using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class MyServiceTasks
    {
        public static void SvcTask1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(5000);
            Console.WriteLine("Task 1 ending");
        }
        public static void SvcTask2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 2 ending");
        }
        public static void SvcWorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(1000);
            Console.WriteLine("Finished working on: " + item);
        }

        public async void SvcLongTask(string numberOfValues)
        {
            Console.WriteLine("Started working on Long Task...Calculating ");
            //Thread.Sleep(10000);
            long noOfValues = long.Parse(numberOfValues);
            double result = await (asyncComputeAverages(noOfValues));
            Console.WriteLine("Finished working on Long Task. Result is " + result.ToString());
        }

        private Task<double> asyncComputeAverages(long noOfValues)
        {
            return Task<double>.Run(() =>
            {
                return computeAverages(noOfValues);
            });
        }

        private double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();
            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rand.NextDouble();
            }
            return total / noOfValues;
        }
    }
}
