
-------------------------------------------------------------------
10
---
Write an application named **Perfect** that displays every perfect number from 1 through 
10,000. A number is perfect if it equals the sum of all the smaller positive integers 
that divide evenly into it. For example, 6 is perfect because 1, 2, and 3 divide 
evenly into it and their sum is 6.

11
---
In a “You Do It” section of this chapter, you created a tipping table for patrons to use 
when analyzing their restaurant bills. Now, create a modified program named **TippingTable3**
in which each of the following values is obtained from user input:

* The lowest tipping percentage

* The highest tipping percentage

* The lowest possible restaurant bill

* The highest restaurant bill

12
---
Write a program named **WebAddress** that asks a user for a business name. Suggest a good Web 
address by adding *www.* to the front of the name, removing all spaces from the name, and adding 
*.com* to the end of the name. For example, a good Web address for Acme Plumbing and Supply is 
*www.AcmePlumbingandSupply.com*.

13
---
Write a program named **CountVowels** that accepts a phrase from the user and counts the number of 
vowels in the phrase. For this exercise, count both uppercase and lowercase vowels, but do not 
consider *y* to be a vowel.

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