using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Construct Binary heap from an array
 *  
 *  Binary heap is a complete binary tree
 *  
 *  For every index, we need to find left and right child
 *  
 *  root = index = 0
 *  left child = 2*i + 1
 *  right child = 2*i + 2
 * 
 * 
 */

namespace SortingAlgorithms.Alg
{
    internal class BinaryHeap
    {
        public int[] Arr { get; set; }

        public BinaryHeap(int[] input)
        {
            Arr = input;
        }

        /*  Max Heap property should start from the bottom most subtree
         * 
         *  Take the bottom most (starting from right) and check for MaxHeap (parent should be greater than children and max should be at the root)
         *  
         *  Swap nodes if MaxHeap is not satisfied.
         *  Once swapped, re-check the maxheap property on the swapped node
         * 
         * ex: arr = [10, 20, 40, 30, 80, 60, 50]
         * size = 6 (last index of the array)
         * 
         *          10
         *         /   \
         *       20     40
         *      /  \   /  \
         *    30   80 60  50
         */


        public void BuildHeap(int size)
        {
            for (int i = size / 2; i >=0; i--)
            {
                MaxHeapify(Arr, i, size);
            }
        }

        private void MaxHeapify(int[] arr, int index, int size)
        {
            var left = 2 * index + 1;
            var right = left + 1;

            int max = index;

            if (left <= size && arr[left] > arr[max])
                max = left;

            if (right <= size && arr[right] > arr[max])
                max = right;

            if(index != max)
            {
                Helpers.SwapWithTuple(arr, max, index);

                MaxHeapify(arr, max, size);
            }
        }
    }
}
