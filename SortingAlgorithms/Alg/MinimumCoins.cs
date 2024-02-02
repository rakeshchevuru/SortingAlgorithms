using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

/*
 * Greedy Algorithm
 * 
 */

namespace SortingAlgorithms.Alg
{
    public class MinimumCoins
    {
        public int[] Coins;

        public MinimumCoins(int[] coins)
        {
            Coins = coins;
        }

        public int findMinCoins(int[] coins, int size, int value) 
        {
            var ans =new int[int.MaxValue];

            int i, count = 0;

            for (i = 0; i < size; i++)
            {
                while(value >= coins[i])
                {
                    value -= coins[i];
                    ans[count] = coins[i];
                    count++;
                }

                if (value == 0)
                    break;
            }

            return count;
        }
    }
}
