using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciImplementation
    {
        //O(2^n) time | O(n) space
        public int FibonacciNaive(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            return FibonacciNaive(n - 1) + FibonacciNaive(n - 2);
        }

        //O(n) time | O(n) space
        public int FibonacciMemoize(int n, Dictionary<int, int> memoize)
        {
            if (!memoize.ContainsKey(1) || !memoize.ContainsKey(2))
            {
                memoize.Add(1, 0);
                memoize.Add(2, 1);
            }
            if (memoize.ContainsKey(n))
            {
                return memoize[n];
            }
            else
            {
                memoize[n] = FibonacciMemoize(n - 1, memoize) + FibonacciMemoize(n - 2, memoize);
                return memoize[n];
            }
        }

        //O(n) time | O(n) space
        public int FibonacciMemoizeV2(int n, Dictionary<int, int> cache)
        {
            if (!cache.ContainsKey(1) || !cache.ContainsKey(2))
            {
                cache.Add(1, 0);
                cache.Add(2, 1);
            }
            Func<int, int> result = MemoizeHelper.Memoize(x => FibonacciMemoizeV2(x - 1, cache) + FibonacciMemoizeV2(x - 2, cache), cache);
            return result(n);
        }

        //O(n) time | O(1) space
        public int FibonacciOptimized(int n)
        {
            int[] cache = new int[2] { 0, 1 };
            int counter = 3;
            while (counter <= n)
            {
                int newFib = cache[0] + cache[1];
                cache[0] = cache[1];
                cache[1] = newFib;
                counter++;
            }
            return n == 1 ? cache[0] : cache[1];
        }
    }

    public static class MemoizeHelper
    {
        public static Func<K, V> Memoize<K, V>(Func<K, V> func, Dictionary<K,V> cache)
        {
            return k =>
            {
                if (cache.TryGetValue(k, out V value))
                {
                    return value;
                }
                value = func(k);
                cache.Add(k, value);
                return value;
            };
        }
    }
}
