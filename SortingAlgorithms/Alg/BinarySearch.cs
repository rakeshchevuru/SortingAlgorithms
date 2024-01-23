using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Alg
{
    internal class BinarySearch
    {
        public int[] Arr { get; set; }

        public BinarySearch(int[] input)
        {
            Arr = input;
        }

        public int Search(int key)
        {
            var result = BinarySrchRecursive(0, Arr.Length - 1, key);

            //If result is 1 then the key is found or else not present
            
            return result;
        }

        public int BinarySrchRecursive(int start, int end, int key)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;

                if (Arr[mid] == key)
                    return 1;

                if(Arr[mid] < key)
                    BinarySrchRecursive(mid + 1, end, key);
                else
                    BinarySrchRecursive(start, mid - 1, key);

            }

            return 0;  
        }

        public int BinarySrchIterative(int start, int end, int key)
        {
            int mid;

            while (start <= end)
            {
                mid = (start + end) / 2;

                if (Arr[mid] == key)
                    return 1;

                if (Arr[mid] < key)
                    start = mid + 1;
                else
                    end = mid - 1;

            }

            return 0;
        }
    }
}
