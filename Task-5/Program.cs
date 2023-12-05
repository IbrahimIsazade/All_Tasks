﻿namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.WriteLine(Part1(1234));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 2");
            Console.WriteLine(Part2(123456));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 3");
            Console.WriteLine(Part3(123456789));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 4");
            Console.WriteLine(Part4(12345));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 5");
            Console.WriteLine(Part5(123456));
            Console.WriteLine("- - - - - - - -");
        }

        /* 
           MUELLIM ALLAH HAQQI HAMISINI OZUM YAZMISAM !!! BIR DEFE BELE CHAT-GPT'DEN
           NESE SORUSMAMISAM !!!!
        */

        static int Part1(int number)
        {
            int res = 0;
            if (number >= 1000 && number < 10000)
            {
                while (number >= 1)
                {
                    res += number % 10;
                    number /= 10;
                }
            }
            return res;
        }

        static int Part2(int number)
        {
            int res = 0;
            if (number >= 100_000 && number < 1_000_000)
            {
                number /= 1000;
                while (number >= 1)
                {
                    res += number % 10;
                    number /= 10;
                }
            }
            return res;
        }

        static int Part3(int number)
        {
            if (number >= 100_000_000 && number < 1_000_000_000)
            {         
                number /= 1000;
                number %= 1000;
            }
            return number;
        }

        static int Part4(int number)
        {
            int res = 0;
            if (number >= 10_000 && number < 100_000)
            {
                res += number / 10000;
                res += number % 10;
                res = res * res;
            }
            return res;
        }

        static int Part5(int number)
        {
            int num, reminder, firstNum;
            if (number >= 100_000 && number < 1_000_000)
            {
                num = number / 100_000;
                reminder = number % 10;
                number /= 10;
                firstNum = number / 10_000;
                number = number - (firstNum * 10000);
                number = number * 100 + (reminder*10);
                number += num;
            }
            return number;
        }
    }
}