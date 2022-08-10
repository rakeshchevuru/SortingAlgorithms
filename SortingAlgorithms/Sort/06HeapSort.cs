using SortingAlgorithms.Alg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sort
{
    internal class HeapSort
    {
        public int[] Arr { get; set; }

        public BinaryHeap binaryHeap { get; set; }

        public HeapSort(int[] input)
        {
            Arr = input;
            binaryHeap = new BinaryHeap(Arr);
        }

        public void Sort()
        {
            PerformHeapSort(Arr.Length - 1);
        }

        public void PerformHeapSort(int size)
        {
            binaryHeap.BuildHeap(size);

            while (size > 0)
            {

                Helpers.SwapWithTuple(Arr, 0, size);

                size--;

                binaryHeap.BuildHeap(size);
            }
        }
    }
}
