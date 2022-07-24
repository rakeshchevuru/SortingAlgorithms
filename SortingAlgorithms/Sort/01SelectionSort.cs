using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Select correct element for every position

namespace SortingAlgorithms.Sort
{
    internal class SelectionSort
    {
        public int[] _input { get; set; }

        public SelectionSort(int[] input)
        {
            _input = input;
        }

        public void Sort()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                for (int j = i + 1; j < _input.Length; j++)
                {
                    if (_input[j] < _input[i])
                        Helpers.SwapWithTuple(_input, i, j);
                }
            }
        }
    }
}
