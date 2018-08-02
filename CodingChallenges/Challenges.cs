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
    }
}
