using System.Diagnostics.Metrics;
using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1(2);
            Part2(4, 2);
            Part3(207);
            Part4(22);
            Part5(22);
            Part6();
        }

        static void Part1(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} eddedi cutdur");
            }
            else
            {
                Console.WriteLine($"{num} eddedi cut deyl");
            }
        }

        static void Part2(int a, int b)
        {
            int diff = a / b;
            if (diff * a == b)
            {
                Console.WriteLine("Bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
        }

        static void Part3(int num)
        {
            if (num % 10 == 7)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }

        static void Part4(int num)
        {
            string[] numArr = num.ToString().Split("");
            string last;
            last = numArr[0];
            foreach (string letter in numArr)
            {
                if (letter == last)
                {
                    Console.WriteLine("They're not same !");
                    return;
                }
            }
        }

        static void Part5(int num)
        {
            string[] numArr = num.ToString().Split("");
            string last;
            last = numArr[0];
            foreach (string letter in numArr)
            {
                if (letter == last)
                {
                    Console.WriteLine("They're not same !");
                    return;
                }
            }
        }

        static void Part6()
        {
            // İstifadəçinin Enter Düyməsini sıxdığı müddətcə Yeni bir tələbə əlavə etmə imkanı olsun
            // Daxil edilən tələbə məlumatları Student tipli massivə doldurulsun(Array methodlarını xatırlayın hansı faydalı olar)
            // Enter düyməsi əvəzinə hər hansı başqa düymə sıxdıqda ekran təmizlənsin və
            // Massivə doldurulmuş tələbə məlumatları ekranda çap edilsin(ToString metodunu override etməklə)
            Student[] students = Array.Empty<Student>();
            int count = 0;
            do
            {
                Console.Write("Enter the name of student: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter the date of birth of student: ");
                string birth = Console.ReadLine()!;

                Student student = new Student();

                if (count >= 0)
                {
                    student.id = 0;
                }
                else
                {
                    student.id = students[students.Length - 1].id + 1;
                }

                student.name = name;
                student.dateOfBirth = birth;
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.WriteLine("Students: ");
            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.name}, Date of birth {item.dateOfBirth}");
            }
        }
    }
}