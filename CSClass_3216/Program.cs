using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass_3216 { 

    class FirstClass
{

}
    class SecondClass
    {

    }
    internal class Program
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) return -input;
                else return input;
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            // 랜덤 클래스
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10 + "\n");

            //student
            List<Student> students = new List<Student>()
            {
            new Student() { name = "이지은", grade = 3 },
            new Student() { name = "이수연", grade = 2 },
            new Student() { name = "윤서연", grade = 1 },
            new Student() { name = "김효리", grade = 3 },
            new Student() { name = "다그닥", grade = 2 },
            new Student() { grade = 1, name = "라이스" }
            };

            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
            //21-6 클래스 응용 #6

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
            //22-3 클래스 메소드 #9




            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };






            //23 - 1 #18
        }
    }
}
