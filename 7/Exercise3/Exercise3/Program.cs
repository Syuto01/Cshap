using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            Dog Dog1 = new Dog();
            Dog Dog2 = new Dog();
            Dog1.Name = "ぽち";
            Dog1.Age = 3;
            Dog2.Name = "ジョン";
            Dog2.Age = 5;

            Dog1.ShowProfile();
            Dog2.ShowProfile();

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
            Console.WriteLine(mName + "," + mAge + "歳");
        }
    }
}
