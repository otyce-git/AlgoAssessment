using System;

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
        public int Count(string value)
        {
            value = value.ToLower();
            int vowelCount = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == 'a' || value[i] == 'e' || value[i] == 'i' || value[i] == 'o' || value[i] == 'u' )
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
