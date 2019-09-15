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
            Dog MyDog = new Dog();

            MyDog.Name = "ぽち";
            MyDog.Age = 3;
            MyDog.ShowProfile();
        }
    }

    class Dog
    {
        private String mName = "";
        private int mAge = 0;

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
            Console.WriteLine(mName+","+mAge+"歳");
        }
    }
}
