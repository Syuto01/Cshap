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
            Dog MyDog = new Dog("秋田犬");
            MyDog.Name = "ぽち";
            MyDog.Age = 3;

            MyDog.ShowProfile();
        }
    }

    class Dog
    {
        private String mName = "";
        private int mAge = 0;
        private String mSpecies = "";

        public Dog(String species)
        {
            mSpecies = species;
        }

        public String Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        public int Age
        {
            get
            {
                return mAge;
            }

            set
            {
                mAge = value;
            }
        }

        public void ShowProfile()
        {
            Console.WriteLine(mSpecies+"の"+mName+","+mAge+"歳");
        }
    }
}
