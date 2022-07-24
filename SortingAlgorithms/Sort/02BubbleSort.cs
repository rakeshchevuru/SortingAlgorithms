//Largest or smallest bubble is placed in its correct position in each iteration
//Continously comapre adjacent bubble and then swap

namespace SortingAlgorithms.Sort
{
    internal class BubbleSort
    {
        public int[] Input { get; set; }

        public BubbleSort(int[] input)
        {
            Input = input;
        }

        public void Sort()
        {
            for (int i = 0; i < Input.Length - 1; i++)
            {
                for (int j = 0; j < Input.Length - 1 - i; j++)
                {
                    if (Input[j] > Input[j + 1])
                        Helpers.SwapWithTuple(Input, j, j + 1);
                }
            }
        }
    }
}
