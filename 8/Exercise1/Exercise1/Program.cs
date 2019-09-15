using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            Cat MyCat = new Cat();

            MyCat.Name = "たま";
            MyCat.Age = 3;
            MyCat.ShowProfile();
            MyCat.Sleep();
        }
    }

    class Animal
    {
        public string Name = "";    // 名前
        public int Age = 0;         // 年齢
        public void ShowProfile()
        {
            Console.WriteLine(Name + "," + Age + "歳");
        }
    }

    class Cat : Animal
    {
        public void Sleep()
        {
            Console.WriteLine("スースー");
        }
    }
}
