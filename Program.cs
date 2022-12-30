using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, stno, enno;
            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("------------------------------");
            Console.WriteLine("\n\n");
            Console.Write("input The starting number of range: ");
            stno = int.Parse(Console.ReadLine());
            Console.Write("Input ending number o range: ");
            enno = int.Parse(Console.ReadLine());
            Console.Write("The Prime number between {0} and {1} are:\n",stno,enno);
            for(num = stno; num <= enno; num++)
            {
                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                    Console.WriteLine("{0}",num);
                
            }
            Console.WriteLine();
        }
    }
}
