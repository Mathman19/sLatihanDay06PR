﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0603
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nT = (n - 1) / 2;
            if (n % 2 == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i>j+4 && i+j > nT+4)
                        {
                            Console.Write("*  ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
