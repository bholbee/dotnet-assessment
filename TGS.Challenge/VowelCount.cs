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
        public int FindVowels(string input)
        {
            //return FindVowelsWithHelpArray(input);
            return FindVowelsWithRegex(input);
        }

        private int FindVowelsWithHelpArray(String inputString)
        {
            abridged...
        }

        private int FindVowelsWithRegex(String inputString)
        {
            if (inputString == null) return 0;
            return Regex.Matches(inputString, "[aeiou]", RegexOptions.IgnoreCase).Count;
        }
    }
