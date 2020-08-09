using System.Collections.Generic;

namespace WaysToMakeChange
{
    public class WaysToMakeAChange
    {
        /// <summary>
        /// Given a specific number of coins, count how many ways are to change your money
        /// [1,5,10,25] 12 should return 4
        /// </summary>
        /// O(nd) time | O(n) space
        /// <param name="coins">Provide number of coins to change into.</param>
        /// <param name="amount">Provide amount</param>
        /// <returns>Number of ways</returns>
        public int WaysToChange(int[] coins, int amount)
        {
            List<int> ways = new List<int>();
            for (int i = 0; i <= amount; i++)
            {
                ways.Add(0);
            }
            ways[0] = 1;

            foreach (int coin in coins)
            {
                for (int j = coin; j <= amount; j++)
                {
                    if (coin <= j)
                    {
                        ways[j] += ways[j - coin];
                    }
                }
            }
            return ways[amount];
        }
    }
}
