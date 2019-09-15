using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            CoinCase MyCase = new CoinCase();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("硬貨の種類は?");
                int kind = int.Parse(Console.ReadLine());
                Console.Write("硬貨の枚数は?");
                int count = int.Parse(Console.ReadLine());
                MyCase.AddCoins(kind, count);
            }

            Console.WriteLine("500円は" + MyCase.GetCount(500)+ "枚、" + MyCase.GetAmount(500) + "円");
            Console.WriteLine("100円は" + MyCase.GetCount(100)+ "枚、" + MyCase.GetAmount(100) + "円");
            Console.WriteLine("50円は" + MyCase.GetCount(50)+ "枚、" + MyCase.GetAmount(50) + "円");
            Console.WriteLine("10円は" + MyCase.GetCount(10)+ "枚、" + MyCase.GetAmount(10) + "円");
            Console.WriteLine("5円は" + MyCase.GetCount(5)+ "枚、" + MyCase.GetAmount(5) + "円");
            Console.WriteLine("1円は" + MyCase.GetCount(1)+ "枚、" + MyCase.GetAmount(1) + "円");
            Console.WriteLine("全部で" + MyCase.GetCount() + "枚");
            Console.WriteLine("総額は" + MyCase.GetAmount() + "円");
        }

        class CoinCase
        {
            private int Yen500 = 0;    // 500円硬貨の数
            private int Yen100 = 0;    // 100円硬貨の数
            private int Yen50 = 0;     // 50円硬貨の数
            private int Yen10 = 0;     // 10円硬貨の数
            private int Yen5 = 0;      // 5円硬貨の数
            private int Yen1 = 0;      // 1円硬貨の数

            public void AddCoins(int kind, int count)
            {
                switch (kind)
                {
                    case 500:
                        Yen500 += count;
                        break;
                    case 100:
                        Yen100 += count;
                        break;
                    case 50:
                        Yen50 += count;
                        break;
                    case 10:
                        Yen10 += count;
                        break;
                    case 5:
                        Yen5 += count;
                        break;
                    case 1:
                        Yen1 += count;
                        break;
                }
            }

            public int GetCount(int kind)
            {
                switch (kind)
                {
                    case 500:
                        return Yen500;
                    case 100:
                        return Yen100;
                    case 50:
                        return Yen50;
                    case 10:
                        return Yen10;
                    case 5:
                        return Yen5;
                    case 1:
                        return Yen1;
                }

                return 0;
            }

            public int GetCount()
            {
                return Yen500 + Yen100 + Yen50 + Yen10 + Yen5 + Yen1;
            }

            public int GetAmount(int kind)
            {
                switch (kind)
                {
                    case 500:
                        return Yen500 * 500;
                    case 100:
                        return Yen100 * 100;
                    case 50:
                        return Yen50 * 50;
                    case 10:
                        return Yen10 * 10;
                    case 5:
                        return Yen5 * 5;
                    case 1:
                        return Yen1 * 1;
                }

                return 0;
            }

            public int GetAmount()
            {
                return (Yen500 * 500) + (Yen100 * 100) + (Yen50 * 50)
                        + (Yen10 * 10) + (Yen5 * 5) + Yen1;
            }

        }
    }
}
