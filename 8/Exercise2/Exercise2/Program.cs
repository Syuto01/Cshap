using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            Cat MyCat = new Cat("たま", 3);
            MyCat.ShowProfile();
            MyCat.Sleep();
        }
    }

    class Animal
    {
        public string Name {
            get;
            private set;
        }// 名前
        public int Age {
            get;
            private set;
        }// 年齢
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowProfile()
        {
            Console.WriteLine(Name + "," + Age + "歳");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age): base(name, age)
        {
        }

        public void Sleep()
        {
            Console.WriteLine("スースー");
        }
    }
}
