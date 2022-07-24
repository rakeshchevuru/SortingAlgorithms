//Select correct element for every position

namespace SortingAlgorithms.Sort
{
    internal class SelectionSort
    {
        public int[] Input { get; set; }

        public SelectionSort(int[] input)
        {
            Input = input;
        }

        public void Sort()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = i + 1; j < Input.Length; j++)
                {
                    if (Input[j] < Input[i])
                        Helpers.SwapWithTuple(Input, i, j);
                }
            }
        }
    }
}
