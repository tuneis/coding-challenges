﻿using System;

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

            // Challenge 4
            Console.WriteLine($"Challenge {i++}: {Challenges.SimpleAdding(140)}");

            // wait to exit until user key press
            Console.ReadKey();
        }
    }
}
