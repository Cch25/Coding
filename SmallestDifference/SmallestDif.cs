using System.Collections.Generic;
using System.Linq;

namespace SmallestDifference
{
    public class SmallestDif
    {
        /// <summary>
        /// Given two arrays find the smallest difference of numbers between these two
        /// for eg:
        /// [-1,5,10,20,28,3] - [26,134,135,15,17] the result should be [28,26] diff of 2
        /// O(nlog(n) + mlog(m)) time | O(1) space
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public (int, int) SmallestDifference(List<int> array1, List<int> array2)
        {
            int idx1 = 0;
            int idx2 = 0;
            int diff = int.MaxValue;
            array1.Sort();
            array2.Sort();
            (int, int) bestPair = (0, 0);
            while (idx1 < array1.Count() && idx2 < array2.Count())
            {
                if (array1[idx1] - array2[idx2] == 0)
                {
                    return (array1[idx1], array2[idx2]);
                }
                if (array1[idx1] < array2[idx2])
                {
                    if (array2[idx2] - array1[idx1] < diff)
                    {
                        diff = array2[idx2] - array1[idx1];
                        bestPair = (array1[idx1], array2[idx2]);
                    }
                    idx1++;
                }
                else if (array1[idx1] > array2[idx2])
                {
                    if (array1[idx1] - array2[idx2] < diff)
                    {
                        diff = array1[idx1] - array2[idx2];
                        bestPair = (array1[idx1], array2[idx2]);
                    }
                    idx2++;
                }
            } 
            return bestPair;
        }
    }
}
