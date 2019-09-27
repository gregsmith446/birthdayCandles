using System;

namespace BirthdayCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm runCode = new Algorithm();

            int[] input = new int[] { 4, 5, 5, 7, 1, 1, 0 };

            var result = runCode.BirthdayCakeCandles(input);

            Console.WriteLine(result);

            // expected output is 1
        }
    }

    class Algorithm
    {
        public int BirthdayCakeCandles(int[] ar)
        {

            int highestNumCounter = 0;
            int highestNum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > highestNum)
                {
                    highestNum = ar[i];
                }
            }

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == highestNum)
                {
                    highestNumCounter++;
                }
            }
            return highestNumCounter;
        }
    }
}
