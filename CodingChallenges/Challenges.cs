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
    }
}
