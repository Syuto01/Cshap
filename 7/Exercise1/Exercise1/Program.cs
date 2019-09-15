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
            Dog MyDog = new Dog();

            MyDog.Name = "ぽち";
            MyDog.ShowProfile();
        }
    }

    class Dog
    {
        private string mName = "";

        public string Name
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

        public void ShowProfile()
        {
            Console.WriteLine(mName);
        }
    }
}
