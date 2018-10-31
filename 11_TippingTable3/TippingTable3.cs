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

            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;

            Write("   Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Write("{0,8}", tipRate.ToString("F"));
            tipRate = LOWRATE;
            WriteLine();
            WriteLine("----------------------------------------");
            while(dinnerPrice <= MAXDINNER)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while(tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0,8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
            }

            WriteLine("--End--");
        }
    }
}
