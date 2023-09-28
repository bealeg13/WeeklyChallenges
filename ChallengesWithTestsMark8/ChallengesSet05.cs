using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Security;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //int remainder = startNumber % n;  // calculate the remainder
            //int nextNumber = startNumber + (n - remainder);  // calculate next number that is divisible by n
            //return nextNumber;

            for (int i = startNumber + 1; i <= startNumber + n; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }
            }
            return 0;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;



        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            int sum = 0;
           
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
                                                   
            }
            return sum;
        }
        
        
        public string TurnWordsIntoSentence(string[] words)
        {
                if (words == null || words.Length == 0)
                {
                    return "";
                }

                string result = string.Join(" ", words
                .SelectMany(word => word.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .Where(word => !string.IsNullOrWhiteSpace(word)));
                //string result = string.Join(" ", words.Where(words => !string.IsNullOrWhiteSpace(words)));

                //result = result.TrimEnd();


                result += ".";
                if (result == ".")
                {
                    result = "";
                }
                return result;


        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            {
                
                if (elements == null || elements.Count == 0)
                {
                    return new double[0];
                }
                
                List<double> result = new List<double>();

                for (int i = 1; i < elements.Count; i++)
                {
                    if ((i + 1) % 4 == 0)
                    {
                        result.Add(elements[i]);

                    }
                }
                //result.Add(elements[3]);
                //result.Add(elements[7]);
                //result.Add(elements[11]);
                //result.Add(elements[15]);
                return result.ToArray();
            }

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //if (nums == null || nums.Length == 0)
            //{
            //    return false;
            //}

            //HashSet<double> result = new HashSet<double>();

            //foreach (int num in nums)
            //{
            //    int complement = targetNumber - num;

            //    if (result.Contains(complement) && complement != num)
            //    {
            //        return true;
            //    }
            //    result.Add(complement);
            //}
            //return false;
            //if (nums == null || nums.Length < 2)
            //{
            //    return false;
            //}

            //var distinctNums = nums.Distinct().ToArray();
            //var query = from num1 in distinctNums
            //            from num2 in distinctNums
            //            where num1 != num2 && num1 + num2 == targetNumber
            //            select num1 + num2;
            //return query.Any();

            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            var numSet = new HashSet<int>();
            var targetSet = new HashSet<int>();

            foreach (var num in nums)
            {
                int complement = targetNumber - num;
                if (numSet.Contains(complement))
                {
                    return true;
                }
                numSet.Add(num);
                targetSet.Add(complement);
            }

            return false;

        }    
        
    }
    }
