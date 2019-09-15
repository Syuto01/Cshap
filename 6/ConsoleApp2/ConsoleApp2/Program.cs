using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int average(int x, int y)
        {
            return (x + y) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("4と9の平均="+average(4,9));
        }

        
    }
}
