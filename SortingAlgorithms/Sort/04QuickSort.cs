using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sort
{
    internal class QuickSort
    {
        public int[] Input { get; set; }

        public QuickSort(int[] input)
        {
            Input = input;
        }

        public void Sort()
        {
            QuickSrt(Input, 0, Input.Length - 1);
        }

        public void QuickSrt(int[] arr, int start, int end)
        {
            if(start < end)
            {
                var pIndex = Partion(arr, start, end);
                QuickSrt(arr, start, pIndex - 1);
                QuickSrt(arr, pIndex + 1, end);
            }
        }

        public int Partion(int[] arr, int start, int end)
        {
            var pIndex = start;
            var pivot = arr[end];
            int i;

            for (i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    Helpers.SwapWithTuple(arr, i, pIndex);
                    pIndex++;
                }
            }

            Helpers.SwapWithTuple(arr, end, pIndex);

            return pIndex;
        }

    }
}
