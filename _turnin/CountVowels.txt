/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw5
*/
/*
13
---
Write a program named **CountVowels** that accepts a phrase from the user and counts the number of 
vowels in the phrase. For this exercise, count both uppercase and lowercase vowels, but do not 
consider *y* to be a vowel.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13_CountVowels
{
    class CountVowels
    {
        static void Main(string[] args)
        {
            WriteLine("hw5#13 - Patrick Barnes");
            WriteLine("CountVowels");

            string in_phrase = "";
            int vowelCount = 0;
            char checkLetter = '\0';

            Write("Enter Phrase: ");
            in_phrase = ReadLine();

            for (int i = 0; i < in_phrase.Length; ++i)
            {
                checkLetter = char.ToUpper(in_phrase[i]);
                switch(checkLetter)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowelCount++;
                        break;
                }
            }
            WriteLine("Vowels :" + vowelCount);

            WriteLine("--End--");
        }
    }
}
