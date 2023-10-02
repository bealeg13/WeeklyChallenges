using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false; // Return false for null input collection
            }

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (var item in words)
            {
                if (item != null && item.Equals(word, comparison))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            
            if (num <= 3)
            {
                return true;
            }
            if (num % 2 == 0 || num % 3 == 0) 
            {
                return false;
            }

            int divisor = 5;
            while (divisor * divisor <= num)
            {
                if (num %  divisor == 0 || num % (divisor + 2) == 0)
                {
                    return false;
                }
                divisor += 6;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1; // Return -1 for empty or null input
            }

            Dictionary<char, int> letterIndices = new Dictionary<char, int>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char letter = str[i];

                if (letterIndices.ContainsKey(letter))
                {
                    letterIndices[letter] = -1; // Mark as non-unique
                }
                else
                {
                    letterIndices[letter] = i; // Store the index of the first occurrence
                }
            }

            int lastIndex = -1;

            foreach (var kvp in letterIndices)
            {
                if (kvp.Value != -1 && (lastIndex == -1 || kvp.Value > lastIndex))
                {
                    lastIndex = kvp.Value;
                }
            }

            return lastIndex;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1; // Minimum count is 1
            int currentCount = 1; // Current consecutive count

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[] { }; // Return an empty array for invalid inputs
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
