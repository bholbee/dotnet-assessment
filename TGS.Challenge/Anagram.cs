using System;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {

        public bool AreAnagrams(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return true;
            }
            if (word1 == null || word2 == null)
            {
                return false;
            }
            
            //Convert string to character array  
            char[] wordOneArray = word1.ToLower().ToCharArray();
            char[] wordTwoArray = word2.ToLower().ToCharArray();
            //Sort array  
            //Array.Sort(wordOneArray);
            //Array.Sort(wordTwoArray);
            //Check each character and position.  
            for (int i = 0; i < wordOneArray.Length; i++)
            {
                if (wordOneArray[i].ToString() != wordTwoArray[i].ToString())
                {
                     return true;
                }
                if (wordOneArray[i].ToString().Length > wordTwoArray[i].ToString().Length)
                {
                    return false;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string word1, word2;  
            Console.WriteLine("Please enter your first word");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            word2 = Console.ReadLine();
            Anagram anagram = new Anagram();
            //Check 
            if (anagram.AreAnagrams(word1, word2) == true)
            {
                Console.WriteLine("these are anagrams.");
            }
            else
            {
                Console.WriteLine("these are not anagrams.");
            }
            Console.ReadLine();
        }
    }
}
