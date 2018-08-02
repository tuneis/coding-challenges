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

            #region Easy Difficulty
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
            #endregion

            // wait to exit until user key press
            Console.ReadKey();
        }
    }
}
