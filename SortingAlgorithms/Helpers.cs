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

        public static string ToBase62(ulong n)
        {
            var alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            ulong bse = 62;

            var ret = "";

            while (n > 0)
            {
                ulong temp = n % bse;
                ret = alphabet[(int)temp] + ret;
                n /= bse;
            }

            return ret;
        }
    }
}
