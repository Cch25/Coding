﻿namespace Questions.MoveElementToEnd
{
    public class MoveToEnd
    {
        /// <summary>
        /// Given an array of integers, move the specified element at the end of the array
        /// Eg [ 2, 1, 2, 2, 2, 3, 4, 2 ] , 2 should become [1, 3, 4, 2, 2, 2, 2, 2]
        /// O(n) time | O(1) space
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public int[] MoveElementToEnd(int[] array, int element)
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != element)
                {
                    array[index] = array[i];
                    array[i] = element;
                    index++;
                }
            }
            return array;
        }
    }
}
