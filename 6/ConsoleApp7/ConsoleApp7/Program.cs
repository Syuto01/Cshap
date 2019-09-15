using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 1000; n++)
                if (IsPrimeNumber(n))
                    Console.Write(n+" ");
        }

        static bool IsPrimeNumber(int num)
        {
            if (num <= 3)
                return true;

            for (int i = 2; i <= (num / 2); i++)
                if ((num % i) == 0)
                    return false;

            return true;
        }
    }
}
