using System.Text;

namespace EasyQuestions.Palindrome
{
    public class FindPalindrome
    {
        //O(2^n) time | O(n) space
        public bool NaivePalindrome(string word)
        {
            string newString = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                newString += word[i];
            }
            return word.Equals(newString);
        }

        //O(n) time | O(n) space
        public bool IsPalindromeSolutionTwo(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            return word.Equals(sb.ToString());
        }

        //O(n) time | O(n) space
        public bool IsPalindromeRecursive(string word, int left = 0)
        {
            int right = word.Length - 1 - left;
            if (left > right)
            {
                return true;
            }
            if (word[left] != word[right])
            {
                return false;
            }
            return IsPalindromeRecursive(word, left + 1);
        }

        //O(n) time | O(1) space
        public bool IsPalindrome(string word)
        {
            int leftPointer = 0;
            int rightPointer = word.Length - 1;
            while (leftPointer < rightPointer)
            {
                if(word[leftPointer] != word[rightPointer])
                {
                    return false;
                }
                leftPointer++;
                rightPointer--;
            }
            return true;
        }
    }
}
