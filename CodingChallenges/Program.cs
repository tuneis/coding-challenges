using System;

namespace CodingChallenges
{
    class Program
    {
        /// <summary>
        /// Entry point to application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // incrementer
            int i = 1;

            // Challenge 1
            Console.WriteLine($"Challenge {i++}: {Challenges.FirstReverse("Reverse This!")}");

            // Challenge 2
            Console.WriteLine($"Challenge {i++}: {Challenges.FirstFactorial(8)}");

            // Challenge 3
            Console.WriteLine($"Challenge {i++}: {Challenges.LongestWord("I love dogs")}");

            // Challenge 4
            Console.WriteLine($"Challenge {i++}: {Challenges.LetterChanges("fun times!")}");

            // Challenge 5
            Console.WriteLine($"Challenge {i++}: {Challenges.SimpleAdding(140)}");

            // Challenge 6
            Console.WriteLine($"Challenge {i++}: {Challenges.LetterCapitalize("i ran there")}");

            // Challenge 7
            Console.WriteLine($"Challenge {i++}: {Challenges.SimpleSymbols("+f++d++++s+g=")}");

            // Challenge 8
            Console.WriteLine($"Challenge {i++}: {Challenges.CheckNums(67, 67)}");

            // Challenge 9
            Console.WriteLine($"Challenge {i++}: {Challenges.TimeConvert(63)}");

            // Challenge 10
            Console.WriteLine($"Challenge {i++}: {Challenges.AlphabetSoup("coderbyte")}");

            // Challenge 11
            Console.WriteLine($"Challenge {i++}: {Challenges.KaprekarsConstant(9831)}");

            // Challenge 12
            //Console.WriteLine($"Challenge {i++}: {Challenges.ChessboardTraveling("(2 2)(4 3)")}");
            //Console.WriteLine($"Challenge {i++}: {Challenges.ChessboardTraveling("(1 1)(3 3)")}");
            //Console.WriteLine($"Challenge {i++}: {Challenges.ChessboardTraveling("(1 1)(2 2)")}");

            // Hacker Rank Challenges
            Console.WriteLine($"Challenge {i++}: {Challenges.DiagonalAbsoluteDifference(new int[][] { new int[] { 11, 2, 4 }, new int[] { 4, 5, 6 }, new int[] { 10, 8, -12 }, })}");
            Challenges.PlusMinus(new int[] { -4, 3, -9, 0, 4, 1 });
            Challenges.Staircase(6);
            Challenges.MiniMaxSum(new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 });
            Challenges.BirthdayCakeCandles(new int[] { 3, 2, 1, 3 });
            Challenges.TimeConversion("07:05:45PM");
            Challenges.Kangaroo(0, 3, 4, 2);

            // wait to exit until user key press
            Console.ReadKey();
        }
    }
}
