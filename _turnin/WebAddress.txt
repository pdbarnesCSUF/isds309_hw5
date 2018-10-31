/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw5
*/
/*
12
---
Write a program named **WebAddress** that asks a user for a business name. Suggest a good Web 
address by adding *www.* to the front of the name, removing all spaces from the name, and adding 
*.com* to the end of the name. For example, a good Web address for Acme Plumbing and Supply is 
*www.AcmePlumbingandSupply.com*.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _12_WebAddress
{
    class WebAddress
    {
        static void Main(string[] args)
        {
            WriteLine("hw5#12 - Patrick Barnes");
            WriteLine("WebAddress");

            string in_name = "";
            string noSpaces = "";
            Write("Business name:");
            in_name = ReadLine();
            //strip spaces
            for (int i = 0; i < in_name.Length; ++i)
            {
                if (in_name[i] != ' ')
                    noSpaces += in_name[i];
            }
            WriteLine("www.{0}.com",noSpaces);

            WriteLine("--End--");
        }
    }
}
