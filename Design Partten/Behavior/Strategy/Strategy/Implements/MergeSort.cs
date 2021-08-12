using Strategy.Interfaces;
using System;

namespace Strategy.Implements
{
    public class MergeSort : ISortStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Merge Sort");
        }
    }
}
