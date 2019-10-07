using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay06quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nT = (n - 1) / 2;
            if (n % 2 == 1)
                // || i <= nT && i > j || j >= nT && i + j < n - 1
                //i >= nT + 1 && i <= j + 4 && j <= nT
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i>j-nT && i < j+nT && i + j >= nT - (nT/2-1) && i+j <= nT+(nT/2+1))
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
