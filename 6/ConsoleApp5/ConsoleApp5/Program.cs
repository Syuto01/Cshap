using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle2(3,'%');
            Console.WriteLine();
            DrawTriangle2(5, '#');
            Console.WriteLine();
            DrawTriangle2(7, '@');
        }

        static void DrawTriangle2(int size,char ch)
        {
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(ch);

                Console.WriteLine();
            }
        }
    }
}
