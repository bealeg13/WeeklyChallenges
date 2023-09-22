using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
                else 
                {
                    result -= numbers[i];
                }
            }
            return result;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] stringArray = { str1, str2, str3, str4 };
            string shortestString = stringArray.OrderBy(x => x.Length).FirstOrDefault();
            
            if (shortestString == null)
            {
                return 0;
            }
            return shortestString.Length;
            

           
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numberArray = { number1, number2, number3, number4 };
            int smallestNumber = numberArray.OrderBy(x => x).FirstOrDefault();
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            Console.WriteLine(biz.Name);
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
           if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2) 
            {
                return true;
            }
           return false;    
          
        }

        public bool IsStringANumber(string input)
        {
            //char[] chars = input.ToCharArray();
            //foreach (char c in chars) 
            //{
            //    if (char.)
            //    {
            //        return false;
            //    }
            //}
            //return true;

            //return !string.IsNullOrWhiteSpace(input) && input.All(char.IsDigit);
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            if (double.TryParse(input, out _))
            {
                return true;
            }
            return false;

            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullValues = 0;
            int noNullValues = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullValues++;
                }
                else
                {
                    noNullValues++;
                }

            }
            return nullValues > noNullValues;
            
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            double result = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                    count++;
                }
                
            }
            if (count == 0)
            {
                return 0;
            }
            return result / count; 
        }

        public int Factorial(int number)
        {
           if (number <= 1)
            {
                return 1;
            }
           else
            {
                return number * Factorial(number -1);
            }
        }
    }
}
