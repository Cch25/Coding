using System;

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
            int[] ways = new int[amount + 1];
            for (int i = 0; i <= amount; i++)
            {
                ways[i] = 0;
            }
            ways[0] = 1;
            foreach (int coin in coins)
            {
                for (int currAmount = coin; currAmount <= amount; currAmount++)
                {
                    ways[currAmount] += ways[currAmount - coin];
                }
            }
            return ways[amount];
        }
        /// <summary>
        /// Given an array of coins [1, 2, 4]
        /// What's the minimum number of coins to make a change for $6?
        /// O(nd) time | O(n)
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int MinNumsOfCoinsToChange(int[] coins, int amount)
        {
            int[] numOfCoins = new int[amount + 1];
            for (int i = 0; i <= amount; i++)
            {
                numOfCoins[i] = int.MaxValue;
            }
            numOfCoins[0] = 0;
            foreach (int coin in coins)
            {
                for (int currAmount = coin; currAmount <= amount; currAmount++)
                {
                    numOfCoins[currAmount] = Math.Min(numOfCoins[currAmount], 1 + numOfCoins[currAmount - coin]);
                }
            }
            return numOfCoins[amount] != int.MaxValue ? numOfCoins[amount] : -1;
        }
    }
}
