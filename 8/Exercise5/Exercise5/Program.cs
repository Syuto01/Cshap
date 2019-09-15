using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            Animal[] MyPets = new Animal[4];
            MyPets[0] = new Cat("たま", 3);
            MyPets[1] = new Dog("ぽち", 4);
            MyPets[2] = new Cat("ミケ", 4);
            MyPets[3] = new Dog("ジョン", 5);

            foreach (Animal Pet in MyPets)
            {
                Pet.ShowProfile();
                Pet.Speak();
            }
        }
    }

    class Animal
    {
        public string Name
        {
            get;
            private set;
        }    // 名前
        public int Age
        {
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
        public Cat(string name, int age) : base(name, age)
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
        public Dog(string name, int age) : base(name, age)
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
