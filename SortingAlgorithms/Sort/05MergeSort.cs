using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sort
{
    public class MergeSort
    {
        public int[] Input { get; set; }

        public MergeSort(int[] input)
        {
            Input = input;
        }

        public void Sort()
        {
            MrgSort(Input, 0, Input.Length - 1);
        }

        public void MrgSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                MrgSort(arr, start, mid);

                MrgSort(arr, mid + 1, end);

                Merge(arr, start, mid, end);
            }
        }

        private void Merge(int[] arr, int start, int mid, int end)
        {
            int i, j, k;

            int n1 = mid - start + 1;

            int n2 = end - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[start + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            k = start;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private void Merge2(int[] array, int start, int mid, int end)
        {
            var leftArrayLength = mid - start + 1;
            var rightArrayLength = end - mid;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];

            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[start + i];

            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[mid + 1 + j];

            i = 0;
            j = 0;
            int k = start;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
    }
}
