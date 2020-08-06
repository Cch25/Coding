namespace ThreeLargestNumbers
{
    public class ThreeLargestNo
    {
        /// <summary>
        /// Given a shuffled array of numbers, find the three greatest numbers
        /// Order the largest numbers ascending
        /// [141, 1, 17, 4, 3, 12, 18, 541, 8, 1, 2]
        /// </summary>
        /// <param name="array"></param>
        /// O(n) time | O(1) space
        public ulong[] FindThreeLargestNumbers(ulong[] array)
        {
            ulong[] largestNumbers = new ulong[3] { ulong.MinValue, ulong.MinValue, ulong.MinValue };
            foreach (ulong number in array)
            {
                FindLargest(number, largestNumbers, 2);
            }
            return largestNumbers;
        }

        private void FindLargest(ulong number, ulong[] largestNumbers, int index)
        {
            for (int i = index; i >= 0; i--)
            {
                if (largestNumbers[i] < number)
                {
                    ShiftAndUpdate(largestNumbers, number, i);
                    break;
                }
            }
        }

        private void ShiftAndUpdate(ulong[] largestNumbers, ulong number, int index)
        {
            for (int i = 0; i <= largestNumbers.Length - 1; i++)
            {
                if (i == index)
                {
                    largestNumbers[i] = number;
                    break;
                }
                else
                {
                    largestNumbers[i] = largestNumbers[i + 1];
                }
            }
        }
    }
}
