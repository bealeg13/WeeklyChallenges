using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }

            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            int sum = numbers.Sum();
            
            
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;
            
            char[] chars = password.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsLower(c)) 
                {
                    isLower = true; 
                }
                else if (char.IsUpper(c))
                {
                    isUpper = true;
                }
                else if (char.IsDigit(c))
                {
                     isNumber = true;
                }
                if (isUpper && isNumber && isLower)
                {
                    return true;
                }
            }
            return false;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            //char firstLetter = ' ';
            //char[] chars = val.ToCharArray();
            //if (chars.Length > 0) 
            //{
            //    firstLetter = chars[0];
            //}
            //return firstLetter;
            return val[0];
            
        }

        public char GetLastLetterOfString(string val)
        {
            //char lastLetter = ' ';
            //char[] chars = val.ToCharArray();
            //if (chars.Length > 0)
            //{
            //    lastLetter = chars[chars.Length - 1];
            //}
            //return lastLetter;
            //return (val[val.Length - 1]);
            return (val[^1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            
            decimal result = dividend / divisor;
            return Math.Round(result, 4);
        }

        public int LastMinusFirst(int[] nums)
        {
            //int firstNumber = nums[0];
            //int lastNumber = nums[nums.Length - 1];
            //int result = lastNumber - firstNumber;
            //if (nums.Length > 0)
            //{
            //    return result;
            //}
            //return 0;
            return nums.Last() - nums.First();


        }

        public int[] GetOddsBelow100()
        {
            var listTo100 = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    listTo100.Add(i);
                }
            }
            return listTo100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            //Console.WriteLine(string.Join("", words));
            Console.WriteLine(words);

        }
    }
}
