using System.Collections.Generic;
using System.Linq;

namespace EasyQuestions.TwoNumberSum
{
    /// <summary>
    /// Find the pair of numbers in an array that sums to the target value
    /// Conditions:
    /// Each number in array shoudn't repeat twice.
    /// Tests:
    /// { 3, 5, -4, 8, 11, 1, -1, 6 } should return (11 -1)
    /// </summary>
    public class TwoNoSum
    {
        //O(n^2) time | O(1) space
        public (int LeftS1, int RightS1) SolutionOne(int[] array, int target)
        {
            List<int> distinctValuesArray = array.Distinct().ToList();
            for (int i = 0; i < distinctValuesArray.Count(); i++)
            {
                for (int j = i + 1; j < distinctValuesArray.Count(); j++)
                {
                    if (distinctValuesArray[i] + distinctValuesArray[j] == target)
                    {
                        return (LeftS1: distinctValuesArray[i], RightS1: distinctValuesArray[j]);
                    }
                }
            }
            return (LeftS1: 0, RightS1: 0);
        }

        //O(n) time | O(n) space
        public (int LeftS2, int RightS2) SolutionTwo(int[] array, int target)
        {
            HashSet<int> numbers = new HashSet<int>();
            List<int> distinctValuesArray = array.Distinct().ToList();
            for (int i = 0; i < distinctValuesArray.Count(); i++)
            {
                int neededNumber = target - distinctValuesArray[i];
                if (numbers.Contains(neededNumber))
                {
                    return (LeftS2: neededNumber, RightS2: distinctValuesArray[i]);
                }
                else
                {
                    numbers.Add(distinctValuesArray[i]);
                }
            }
            return (LeftS2: 0, RightS2: 0);
        }

        //O(nlog(n) time | O(1)
        public (int LeftS3, int RightS3) SolutionThree(int[] array, int target)
        {
            List<int> distinctValuesArray = array.Distinct().ToList();
            distinctValuesArray.Sort();//O(nlog(n))
            int leftPointer = 0;
            int rightPointer = array.Length - 1;
            while (leftPointer <= rightPointer)
            {
                if (distinctValuesArray[leftPointer] + distinctValuesArray[rightPointer] == target)
                {
                    return (LeftS3: distinctValuesArray[leftPointer], RightS3: distinctValuesArray[rightPointer]);
                }
                else if (distinctValuesArray[leftPointer] + distinctValuesArray[rightPointer] < target)
                {
                    leftPointer++;
                }
                else if (distinctValuesArray[leftPointer] + distinctValuesArray[rightPointer] > target)
                {
                    rightPointer--;
                }
            }
            return (LeftS3: 0, RightS3: 0);
        }

    }
}
