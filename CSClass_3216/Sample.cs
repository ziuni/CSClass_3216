using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass_3216
{
    internal class Sample
    {
        public static int value = 42;

        static Sample()
        {
            value = 3203;
            Console.WriteLine("Sample() 정적 생성자 호출");
        }

        public Sample()
        {
            Console.WriteLine("Sample() 일반 생성자 호출");
        }

        ~Sample()
        {
            Console.WriteLine("Sample() 소멸자 호출");
        }
    }
}
//22-6~7 생성자~소멸자 #12#13