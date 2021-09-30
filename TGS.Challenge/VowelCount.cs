using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public static bool isVowel(char ch)
        {
            ch = char.ToLower(ch);
            return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
        }
        
        public int Count(string value)
        {
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                // Checking vowel count
                if (isVowel(value[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
