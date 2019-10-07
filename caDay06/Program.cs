using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nT = (n - 1) / 2;
            if (n % 2 == 1)
            {
                for (int i =0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i==0 || j==n-1 || j==0 || i==j || i+j==n-1 || i==n-1)
                        {
                            if (i==nT && j == nT)
                            {
                                Console.Write("M  ");
                            }
                            else
                            {
                                Console.Write("*  ");
                            }
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
