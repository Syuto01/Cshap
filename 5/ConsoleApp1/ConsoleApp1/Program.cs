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
            int x = 1; //intはデータ型(整数型)でxは変数(文字や数値等のデータを入れるための箱)名、「=1」はこの変数xを1で初期化する
            int y = 1;
            int z = x + y;
            Console.WriteLine("z={0}",z);//表示する文字列は"z={0]"としてその後に「,」で続けてzと入力。「z=x+y」。
            Console.ReadKey();
            //コンソール画面では「z=2」と表示される
        }
    }
}
