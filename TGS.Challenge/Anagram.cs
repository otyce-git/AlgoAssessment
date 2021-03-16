using System.Collections;
using System.Text.RegularExpressions;

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
            word1 = Regex.Replace(word1.ToLower(), @"[\W_-[\s]]+", string.Empty);
            word2 = Regex.Replace(word2.ToLower(), @"[\W_-[\s]]+", string.Empty);

            if (word1.Length != word2.Length)
                return false;

            var word1ArrayList = new ArrayList();
            for (int i = 0; i < word1.Length; i++)
            {
                word1ArrayList.Add(word1[i]);
            }

            var word2ArrayList = new ArrayList();
            for (int i = 0; i < word2.Length; i++)
            {
                word2ArrayList.Add(word2[i]);
            }

            word1ArrayList.Sort();
            word2ArrayList.Sort();

            for (int i = 0; i < word1ArrayList.Count; i++)
            {
                if (!word1ArrayList[i].Equals(word2ArrayList[i]))
                    return false;
            }

            return true;
      }
    }
}
