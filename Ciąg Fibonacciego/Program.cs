using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciąg_Fibonacciego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podajjjjj którą liczbę w kolejności chcesz uzyskać :");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(" 0");
            }
            if(n==1 || n==2)
            {
                Console.WriteLine("1");
            }
            else
            {
                int a = 1;
                int b = 1;
                int c = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                 Console.WriteLine("wynik dla " + n + "-tego wyrazu to " + b);         
            }
            Console.ReadKey();
        }
    }
}

