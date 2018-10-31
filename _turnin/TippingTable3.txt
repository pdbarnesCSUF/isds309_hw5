/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw5
*/
/*
11
---
In a “You Do It” section of this chapter, you created a tipping table for patrons to use 
when analyzing their restaurant bills. Now, create a modified program named **TippingTable3**
in which each of the following values is obtained from user input:

* The lowest tipping percentage

* The highest tipping percentage

* The lowest possible restaurant bill

* The highest restaurant bill
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11_TippingTable3
{
    class TippingTable3
    {
        static void Main(string[] args)
        {
            WriteLine("hw5#11 - Patrick Barnes");
            WriteLine("TippingTable3");
            
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;
            double lowRate = 0.10;
            double maxRate = 0.25;
            double maxDinner = 100.00;
            const double TIPSTEP = 0.05;
            const double DINNERSTEP = 10.00;

            WriteLine("(0.10 = 10%)");
            Write("lowest tip rate:");
            lowRate = double.Parse(ReadLine());
            Write("max tip rate:");
            maxRate = double.Parse(ReadLine());
            Write("min dinner price:");
            dinnerPrice = double.Parse(ReadLine());
            Write("max dinner price:");
            maxDinner = double.Parse(ReadLine());

            Write("   Price");
            for (tipRate = lowRate; tipRate <= maxRate; tipRate += TIPSTEP)
                Write("{0,8}", tipRate.ToString("F"));
            tipRate = lowRate;
            WriteLine();
            WriteLine("----------------------------------------");
            while(dinnerPrice <= maxDinner)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while(tipRate <= maxRate)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0,8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = lowRate;
                WriteLine();
            }

            WriteLine("--End--");
        }
    }
}
