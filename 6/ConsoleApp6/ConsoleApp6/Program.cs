using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
                KukuColumn(i);
        }

        static void KukuColumn(int num)
        {
            for (int i = 1; i <= 9; i++)
                Console.Write("{0,2}",num*i);

            Console.WriteLine();
        }
    }
}
