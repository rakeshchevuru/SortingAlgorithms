using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Alg
{
    internal class KthLargestElement
    {
        public int FindKthLargest(int[] nums, int k)
        {

            //Time Complexity: O(N * log K)
            //Space Compelexity: O(K)

            var pq = new PriorityQueue<int, int>();

            foreach (var i in nums)
            {
                pq.Enqueue(i, i);

                if (pq.Count > k)
                    pq.Dequeue();
            }

            return pq.Peek();
        }


        public int FindKthSmallestByMax(int[] nums, int k)
        {

            //Time Complexity: O(N * log K)
            //Space Compelexity: O(K)

            PriorityQueue<int, int> pq = new(new IntMaxCompare());

            foreach (var i in nums)
            {
                pq.Enqueue(i, i);

                if (pq.Count > k)
                    pq.Dequeue();
            }

            int kthMax = 0;

            while (pq.Count > 0)
            {
                kthMax = pq.Dequeue();
            }

            return kthMax;
        }
    }


    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
