using Strategy.Interfaces;
using System;

namespace Strategy.Implements
{
    public class SelectionSort : ISortStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Selection Sort");
        }
    }
}
