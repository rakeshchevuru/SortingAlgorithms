namespace SortingAlgorithms
{
    internal static class Helpers
    {
        public static void Swap(int[] input, int index1, int index2)
        {
            var temp = input[index2];
            input[index2] = input[index1];
            input[index1] = temp;
        }

        public static void SwapWithTuple(int[] input, int index1, int index2)
        {
            (input[index1], input[index2]) = (input[index2], input[index1]);
        }
    }
}
