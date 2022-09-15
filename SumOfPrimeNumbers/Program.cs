using System;

namespace SumOfPrimeNumbers
{
    public class Program
    {
        //Method to check whether a number is a prime number
        private static bool IsAPrimeNumber(int num)
        {
            //Number should not be equal to 1
            if (num == 1)
            {
                return false;
            }

            //Number should not be divisible by 2 except 2
            int i;
            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            //Return true when above conditions are false
            if (i == num)
            {
                return true;
            }

            return false;
        }

        //Method to calcualte the sum of prime numbers
        private static int SumOfPrimes(int first, int X)
        {
            int sum = 0;

            for (int i = X; i > first; i--)
            {
                //Checking for a prime number
                bool isPrime = IsAPrimeNumber(i);
                if (isPrime)
                {
                    //Get the Sum
                    sum = sum + i;
                }
            }

            //Return the sum
            return sum;
        }

        private static void Main(string[] args)
        {
            //X should be equal to 33 according to the hints given
            int first = 1, X = 33;

            //Print the sum in console
            Console.Write("\nSum of the prime numbers below X is : "+ SumOfPrimes(first, X));
        }
    }
}
