/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw5
*/
/*
14
---
In Chapter 4, you created a program that generates a random number, allows a user to guess it, and 
displays a message indicating whether the guess is too low, too high, or correct. Now, create a 
modified program called **GuessingGame2** in which the user can continue to enter values until the 
correct guess is made. After the user guesses correctly, display the number of guesses made.

Recall that you can generate a random number whose value is at least min and less than max using 
the following statements:
```cs
Random ranNumber = new Random();
int randomNumber;
randomNumber = ranNumber.Next(min, max);
```
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _14_GuessingGame2
{
    class GuessingGame2
    {
        static void Main(string[] args)
        {
            WriteLine("hw5#14 - Patrick Barnes");
            WriteLine("GuessingGame2");

            const int MIN = 1;  //inclusive
            const int MAX = 11; //exclusive
            int randomNumber = 0;
            int guess = -1;
            int attempts = 0;

            Random ranNumberGenerator = new Random();
            //(inclusive,	exclusive)
            randomNumber = ranNumberGenerator.Next(MIN, MAX);
            //WriteLine("DEBUG:randomNumber={0}",randomNumber); //DEBUG
            while (guess != randomNumber)
            {
                Write("Guess a number ({0}-{1}):", MIN, MAX - 1);
                guess = int.Parse(ReadLine());
                ++attempts;
                if (guess == randomNumber)
                    WriteLine("Correct! {0} attemps.",attempts);
                else if (guess < randomNumber)
                    WriteLine("Too low");
                else
                    WriteLine("Too high");
            }

            WriteLine("--End--");
        }
    }
}
