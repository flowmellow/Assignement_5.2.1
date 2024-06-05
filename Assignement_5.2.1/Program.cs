/*
Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.
Example 1:
Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.

Example 2:
Input: s = " fly me to the moon "
Output: 4
Explanation: The last word is "moon" with length 4.
*/

using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Assignement_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPhrase1 = "Hello World";
            string inputPhrase2 = " fly me to the moon ";



            string[] splitPhrase = inputPhrase1.Split(' ');

            for (int i = splitPhrase.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(splitPhrase[i]))
                {
                    Console.WriteLine($"The last word is \"{splitPhrase[i]}\" with length {splitPhrase[i].Length}.");
                    break;
                }

            }

        }
    }
}
