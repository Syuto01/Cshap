using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 //名前空間を変えるとエラーになり、実行する事ができない
{
    class Program
    {
        static void Main(string[] args)
        {
            TestNameSpace.TestClass.SayHello(); //TestNameSpaceと言う名前空間のTestClassと言うクラスにSayHelloメソッドを呼び出す
            Console.WriteLine("終了するには何かキーを押して下さい");
            Console.ReadLine();
        }
    }
}

namespace TestNameSpace
{
    class TestClass　//TestClass
    {
        public static void SayHello()　//SayHelloメソッド
        {
            Console.WriteLine("Hello world!");
        }
    }
}
