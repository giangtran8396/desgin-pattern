using Strategy.Interfaces;
using System;

namespace Strategy.Implements
{
    public class QuickSort : ISortStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Quick Sort");
        }
    }
}
