using SortingAlgorithms.Sort;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 6, 56, 8, 2, 209, 4 };

            //new SelectionSort(input).Sort();
            //new BubbleSort(input).Sort();
            //new InsertionSort(input).Sort();
            //new MergeSort(input).Sort();
            new HeapSort(input).Sort();

            Console.WriteLine("Hello, World!");
        }
    }
}