using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodingChallenges
{
    /// <summary>
    /// Class to hold first reverse algorithm.
    /// </summary>
    public class Challenges
    {
        /// <summary>
        /// Using the C# language, have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. 
        /// For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstReverse(string str)
        {
            string output = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                output += str[i];
            }
            return output;
        }

        /// <summary>
        /// Using the C# language, have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it (e.g. if num = 4, return (4 * 3 * 2 * 1)). 
        /// For the test cases, the range will be between 1 and 18 and the input will always be an integer. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int FirstFactorial(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                num *= i;
            }
            return num;
        }

        /// <summary>
        /// Using the C# language, have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. 
        /// If there are two or more words that are the same length, return the first word from the string with that length. 
        /// Ignore punctuation and assume sen will not be empty. 
        /// </summary>
        /// <param name="sen"></param>
        /// <returns></returns>
        public static string LongestWord(string sen)
        {
            return Regex.Split(sen, "[^A-Za-z]+")
                .OrderByDescending(s => s.Length)
                .ToArray()[0];
        }

        /// <summary>
        /// Using the C# language, have the function LetterChanges(str) take the str parameter being passed and modify it using the following algorithm. 
        /// Replace every letter in the string with the letter following it in the alphabet (ie. c becomes d, z becomes a). 
        /// Then capitalize every vowel in this new string (a, e, i, o, u) and finally return this modified string. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LetterChanges(string str)
        {
            string output = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    char letter = str[i] == 'z' ? 'a' : (char)(str[i] + 1);
                    switch (letter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            output += char.ToUpper(letter);
                            break;
                        default:
                            output += letter;
                            break;
                    }
                    continue;
                }
                output += str[i];
            }
            return output;
        }

        /// <summary>
        /// Using the C# language, have the function SimpleAdding(num) add up all the numbers from 1 to num. 
        /// For example: if the input is 4 then your program should return 10 because 1 + 2 + 3 + 4 = 10. For the test cases, the parameter num will be any number from 1 to 1000. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int SimpleAdding(int num)
        {
            int output = 0;
            for (int i = 1; i <= num; i++)
            {
                output += i;
            }
            return num;
        }

        /// <summary>
        /// Using the C# language, have the function LetterCapitalize(str) take the str parameter being passed and capitalize the first letter of each word. Words will be separated by only one space. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string LetterCapitalize(string str)
        {
            return string.Join(' ', str.Split(' ').Select(s => char.ToUpper(s[0]) + s.Substring(1, s.Length - 1)));
        }

        /// <summary>
        /// Using the C# language, have the function SimpleSymbols(str) take the str parameter being passed and determine if it is an acceptable sequence by either returning the string true or false.
        /// The str parameter will be composed of + and = symbols with several letters between them (ie. ++d+===+c++==a) and for the string to be true each letter must be surrounded by a + symbol.
        /// So the string to the left would be false. 
        /// The string will not be empty and will have at least one letter. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SimpleSymbols(string str)
        {
            if (char.IsLetter(str[0]) || char.IsLetter(str[str.Length - 1]))
                return "false";

            string result = "true";
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                    continue;

                if (str[i - 1] != '+' || str[i + 1] != '+')
                {
                    result = "false";
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Using the C# language, have the function CheckNums(num1,num2) take both parameters being passed and return the string true if num2 is greater than num1, otherwise return the string false. 
        /// If the parameter values are equal to each other then return the string -1. 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string CheckNums(int num1, int num2)
        {
            return num1 == num2 ? "-1" : num2 > num1 ? "true" : "false";
        }

        /// <summary>
        /// Using the C# language, have the function TimeConvert(num) take the num parameter being passed and return the number of hours and minutes the parameter converts to (ie. if num = 63 then the output should be 1:3). 
        /// Separate the number of hours and minutes with a colon. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string TimeConvert(int num)
        {
            var ts = TimeSpan.FromMinutes(num);
            return $"{ts.Hours}:{ts.Minutes}";
        }

        /// <summary>
        /// Using the C# language, have the function AlphabetSoup(str) take the str string parameter being passed and return the string with the letters in alphabetical order (ie. hello becomes ehllo). 
        /// Assume numbers and punctuation symbols will not be included in the string. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string AlphabetSoup(string str)
        {
            return string.Join(null, str.OrderBy(s => (int)s).Select(s => s));
        }


        /// <summary>
        /// Using the C# language, have the function KaprekarsConstant(num) take the num parameter being passed which will be a 4-digit number with at least two distinct digits. 
        /// Your program should perform the following routine on the number: Arrange the digits in descending order and in ascending order (adding zeroes to fit it to a 4-digit number), and subtract the smaller number from the bigger number. 
        /// Then repeat the previous step. 
        /// Performing this routine will always cause you to reach a fixed number: 6174. 
        /// Then performing the routine on 6174 will always give you 6174 (7641 - 1467 = 6174). 
        /// Your program should return the number of times this routine must be performed until 6174 is reached. 
        /// For example: if num is 3524 your program should return 3 because of the following steps: (1) 5432 - 2345 = 3087, (2) 8730 - 0378 = 8352, (3) 8532 - 2358 = 6174. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int KaprekarsConstant(int num)
        {
            int count = 0;
            int kc = 6174;
            int result = num;
            while (result != kc)
            {
                var str = result.ToString();
                while (str.Length < 4)
                {
                    str += 0;
                }
                int asc = Convert.ToInt32(string.Join(null, str.OrderBy(s => (int)s)));
                int desc = Convert.ToInt32(string.Join(null, str.OrderByDescending(s => (int)s)));
                result = asc > desc ? asc - desc : desc - asc;
                count++;
            }
            return count;
        }

        ///// <summary>
        ///// Using the C# language, have the function ChessboardTraveling(str) read str which will be a string consisting of the location of a space on a standard 8x8 chess board with no pieces on the board along with another space on the chess board.
        ///// The structure of str will be the following: "(x y)(a b)" where (x y) represents the position you are currently on with x and y ranging from 1 to 8 and (a b) represents some other space on the chess board with a and b also ranging from 1 to 8 where a > x and b > y. 
        ///// Your program should determine how many ways there are of traveling from (x y) on the board to (a b) moving only up and to the right. 
        ///// For example: if str is (1 1)(2 2) then your program should output 2 because there are only two possible ways to travel from space (1 1) on a chessboard to space (2 2) while making only moves up and to the right. 
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string ChessboardTraveling(string str)
        //{

        //}

        /// <summary>
        /// Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        /// </summary>
        public static int DiagonalAbsoluteDifference(int[][] arr)
        {
            // left diagonal and right diagonal totals
            int ld = 0;
            int rd = 0;

            // loop through matrix
            for (int i = 0; i < arr.Length; i++)
            {
                // add to left diagonal
                ld += arr[i][i];

                // add to right diagonal
                rd += arr[i][arr.Length - 1 - i];
            }
            return Math.Abs(ld - rd);
        }

        /// <summary>
        /// Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.
        /// </summary>
        /// <param name="arr"></param>
        public static void PlusMinus(int[] arr)
        {
            // positive, negative, zeroes counters
            var p = 0;
            var n = 0;
            var z = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    p++;
                else if (arr[i] == 0)
                    z++;
                else
                    n++;
            }
            Console.WriteLine(p / (float)arr.Length);
            Console.WriteLine(n / (float)arr.Length);
            Console.WriteLine(z / (float)arr.Length);

        }

        /// <summary>
        /// Write a program that prints a right aligned staircase of size n.
        /// </summary>
        /// <param name="n"></param>
        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var stair = "";
                for (int j = 1; j <= n; j++)
                {
                    stair += n - i < j ? "#" : " ";
                }
                Console.WriteLine(stair);
            }
        }

        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
        /// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        /// </summary>
        /// <param name="arr"></param>
        public static void MiniMaxSum(int[] arr)
        {
            // declare min sum and max sum and skip index
            long minSum = long.MaxValue;
            long maxSum = long.MinValue;
            long skipIndex = 0;

            // loop through arr
            for (int i = 0; i < arr.Length; i++)
            {
                // declare min temporary sum
                long tempSum = 0;

                // loop through the array again
                for (int j = 0; j < arr.Length; j++)
                {
                    // skip an element so we only sum n - 1 elements
                    if (j == skipIndex)
                        continue;
                    tempSum += arr[j];
                }

                // check if temp sum is less than min sum
                if (tempSum < minSum)
                    minSum = tempSum;

                // check it temp sum is greater than max sum
                if (tempSum > maxSum)
                    maxSum = tempSum;

                // increment the skip index
                skipIndex++;
            }

            Console.WriteLine($"{minSum} {maxSum}");
        }

        /// <summary>
        /// You are in charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age.
        /// When she blows out the candles, she’ll only be able to blow out the tallest ones.
        /// Your task is to find out how many candles she can successfully blow out.
        /// For example, if your niece is turning 4 years old, and the cake will have 4 candles of height 4, 4, 1, 3, she will be able to blow out 2 candles successfully, since the tallest candles are of height 4 and there are 2 such candles.
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int BirthdayCakeCandles(int[] ar)
        {
            // pre calculate max before filtering by count
            var max = ar.Max();
            return ar.Where(s => s == max).Count();
        }

        /// <summary>
        /// Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
        /// Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock.Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string TimeConversion(string s)
        {
            // parse time string
            var result = DateTime.TryParse(s, out DateTime date);

            // convert to military time
            var parsed = date.ToString("HH:mm:ss");
            return parsed;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/kangaroo/problem
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="v1"></param>
        /// <param name="x2"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            while (x1 < 10000 || x2 < 10000)
            {
                if (x1 == x2)
                    return "YES";

                x1 += v1;
                x2 += v2;
            }
            return "NO";
        }
    }
}
