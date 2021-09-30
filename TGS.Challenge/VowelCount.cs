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
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'E' ||
                    ch == 'I' || ch == 'O' ||
                                  ch == 'U');
        }
        
        public int Count(string value)
         {
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {

                // Check for vowel
                if (isVowel(value[i]))
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
