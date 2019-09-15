using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            Cat MyCat = new Cat("たま", 3);
            Dog MyDog = new Dog("ぽち", 4);
            MyCat.ShowProfile();
            MyDog.ShowProfile();
            MyCat.Speak();
            MyDog.Speak();
        }
    }

    class Animal
    {
        public string Name {
            get;
            private set;
        }    // 名前
        public int Age {
            get;
            private set;
        }   // 年齢

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowProfile()
        {
            Console.WriteLine(Name + "," + Age + "歳");
        }

        public virtual void Speak()
        {
            Console.WriteLine("......");
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

        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age): base(name, age)
        {
        }

        public void Run()
        {
            Console.WriteLine("トコトコ");
        }

        public override void Speak()
        {
            Console.WriteLine("ワンワン");
        }

    }
}
