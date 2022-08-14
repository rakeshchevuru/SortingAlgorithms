using SortingAlgorithms.Sort;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 6, 56, 8, 2, 209, 4 };

            //new SelectionSort(input).Sort();
            //new BubbleSort(input).Sort();
            //new InsertionSort(input).Sort();
            //new MergeSort(input).Sort();
            new HeapSort(input).Sort();

            var t = findMaxProducts(new List<int> { 6, 2, 9, 4, 7, 5, 2 });

            var s = minSwapsRequired("1110");

            Console.WriteLine("Hello, World!");
        }

        public static long findMaxProducts(List<int> products)
        {
            var res = 0;

            for (var i = 0; i < products.Count; i++)
            {               
                res = Math.Max(res, products[i]);

                var j = i - 1;
                var k = products[i];

                var tempres = products[i];

                while (j >= 0 && k > 0)
                {
                    if (products[j] >= k)
                    {
                        k = Math.Max(k - 1, 0);
                        tempres += k;
                    }
                    else
                    {
                        k = products[j];
                        tempres += products[j];
                    }

                    j--;
                }

                res = Math.Max(res, tempres);
            }

            return res;
        }

        public static int minSwapsRequired(string s)
        {
            var count = s.Length;

            var swaps = 0;


            var left = 0;
            var right = count - 1;

            int l, r = 0;

            string swap(int idx1, int idx2)
            {
                var chars = s.ToCharArray();
                (chars[idx1], chars[idx2]) = (chars[idx2], chars[idx1]);
                return new string(chars);
            }

            while (left < right)
            {
                l = left;
                r = right;

                while (s[l] != s[r])
                    r--;



                if (l == r)
                {
                    s = swap(r, r+1);
                    swaps++;
                    continue;
                }
                else
                {
                    var swaped = false;

                    while (r < right)
                    {
                        s = swap(r, r+1);
                        swaped = true;
                        r++;
                    }

                    if (swaped)
                        swaps++;
                }

                left++;
                right--;
            }

            return swaps;

        }
    }
}