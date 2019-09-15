using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle(3);
            Console.WriteLine();
            DrawTriangle(4);
            Console.WriteLine();
            DrawTriangle(5);
        }

        static void DrawTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("$");

                Console.WriteLine();
            }
        }
    }
}
