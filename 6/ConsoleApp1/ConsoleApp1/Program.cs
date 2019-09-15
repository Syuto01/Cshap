using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.1; //floatに変えると赤い波線でエラーメッセージが表示される
            double y = 0.1;
            double z = x + y;
            Console.WriteLine("z={0}",z);　//「z=0.2」と表示される
            Console.ReadKey();
        }
    }
}
