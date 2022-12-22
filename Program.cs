using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_no_findee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, i, sum;
            int m, n;
            Console.WriteLine("Perfect number finder");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter the starting point");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the ending point");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");
            for (x = m ; x <=n; x++)
            {
                i = 1;
                sum = 0;
                while (i <= x/2)
                {
                    if (x % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == x)
                    Console.WriteLine("{0}",x);
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
