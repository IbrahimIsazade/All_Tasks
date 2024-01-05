using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Part1(2);
            Part2(4, 2);
            Part3(207);
            Part4(22);
            Part5(22);
            Part6();

            // Part 7
            CultureInfo culture = new CultureInfo("az");
            DateTime now = DateTime.Now;
            string add ="";
            switch (now.Year % 10)
            {
                case 6:
                    add = "-cı il";
                    break;
                case 1:
                case 2:
                case 5:
                case 7:
                case 8:
                    add = "-ci il";
                    break;
                case 0:
                    switch (now.Year % 100)
                    {
                        case 400:
                        case 600:
                        case 900:
                            add = "-cı il";
                            break;
                        case 200:
                        case 500:
                        case 700:
                        case 800:
                        case 0:
                            if ((now.Year / 100) % 10 == 0)
                            {
                                add = "-ci il";
                                break;
                            }
                            add = "-cü il";
                            break;

                        case 100:
                        case 300:
                            add = "-cu il";
                            break;
                    }
                    break;
                case 9:
                    add = "-cu il";
                    break;
                case 3:
                case 4:
                    add = "-cü il";
                    break;
            }
            culture.DateTimeFormat.LongDatePattern = "d MMMM yyyy"+add;
            Thread.CurrentThread.CurrentCulture = culture;
            Console.WriteLine(now.ToLongDateString());

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
            if (num/10 == num%10)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }

        static void Part5(int num)
        {
            if (num >= 10 && num < 100)
            {
                if ((num/10 + num%10) % 2 == 0)
                {
                    Console.WriteLine((num/10) * (num%10));
                }
                else
                {
                    Console.WriteLine("ədəddə tək rəqəm mövcuddu");
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
            Console.WriteLine("\nStudents: ");
            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.name}, Date of birth {item.dateOfBirth}");
            }
        }

    }
}