using System; //このファイル内ではSystemと言う名前空間は省略する事ができる
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 //名前空間(この行から18行目までの中カッコがこの空間に属している)
{
    class Program //クラスと言う(この行から17行目までの中カッコがこの空間に属している)
    {
        static void Main(string[] args) //メソッド(この行から16行目までの中カッコがこの空間に属していて、この中に処理する内容を記述する)
        {
            Console.WriteLine("Hello World!"); //カッコ内の文字列をコンソールウィンドウに表示する命令(ConsoleがクラスでWriteLineがメソッド。ConsoleクラスはSystemと言う名前空間に属している。)
            Console.ReadKey();
        }
    }
}
