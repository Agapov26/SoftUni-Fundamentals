using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int result = FindResult(num);
            Console.WriteLine(result);

            static int FindResult(int num)
            {
                int rezult = FindSumOfOdds(num) * FindSumOfEvens(num);
                return rezult;
            }

            static int FindSumOfOdds(int num)
            {
                int sumOfOdds = 0;

                while (num > 0)
                {

                    int nextNum = num % 10;
                    num /= 10;
                    if (nextNum % 2 != 0)
                    {
                        sumOfOdds += nextNum;
                    }

                }

                return sumOfOdds;
            }

            static int FindSumOfEvens(int num)
            {
                int sumOfEvens = 0;
                while (num > 0)
                {
                    int nextNum = num % 10;
                    num /= 10;
                    if (nextNum % 2 == 0)
                    {
                        sumOfEvens += nextNum;
                    }

                }
                return sumOfEvens;
            }
        }
    }
}
