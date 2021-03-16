﻿using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            var stringValue = value.ToString();
            var formattedString = string.Empty;
            var count = 0;

            for (int i = stringValue.Length; i > 0; i--)
            {
                count++;

                formattedString = stringValue[i - 1] + formattedString;
                if ((count%3 == 0) && (stringValue.Length > count))
                {
                    formattedString = "," + formattedString;
                }
            }

            return formattedString;
        }
    }
}
