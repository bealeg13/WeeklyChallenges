using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else if (number2 < number1)
            {
                return number2;
            }

            else
            {
                return number1;
            } 

        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            string greeting1 = ($"Hello, {nameOfPerson}!");
            string greeting2 = ("Hello!");
            if (nameOfPerson == "")
            {
                return greeting2;
            }
            else
            {
                return greeting1;
            }
        }

        public string GetHey()
        {
            string word = "HEY!";
            return word;
        }
    }
}
