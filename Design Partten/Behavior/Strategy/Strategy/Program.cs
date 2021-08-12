using Strategy.Implements;
using Strategy.Strategies;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortHelper helper = new SortHelper();

            helper.SetStrategy(new MergeSort());
            helper.Execute();

            helper.SetStrategy(new QuickSort());
            helper.Execute();

            helper.SetStrategy(new SelectionSort());
            helper.Execute();

            Console.ReadLine();
        }
    }
}
