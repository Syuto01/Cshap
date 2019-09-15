using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxValue(x,MaxValue(y,z)));
        }

        static int MaxValue(int n1,int n2)
        {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }
    }
}
