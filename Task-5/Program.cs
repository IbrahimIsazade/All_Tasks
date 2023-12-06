namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.WriteLine(Part1(1234));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 2");
            Console.WriteLine(Part2(123_456));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 3");
            Console.WriteLine(Part3(123_456_789));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 4");
            Console.WriteLine(Part4(12_345));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 5");
            Console.WriteLine(Part5(123_456));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 6");
            Console.WriteLine(Part6(12_345_678));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 7");
            Console.WriteLine(Part7(1_234));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 8");
            Console.WriteLine(Part8(12_345));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 9");
            Console.WriteLine(Part9(123_456_789));
            Console.WriteLine("- - - - - - - -");

            Console.WriteLine("Part 10");
            Console.WriteLine(Part10(123_456_789));
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
                number = number * 100 + (reminder * 10);
                number += num;
            }
            return number;
        }

        static int Part6(int number)
        {
            int reminder;
            if (number >= 10_000_000 && number < 100_000_000)
            {
                number /= 10;
                reminder = number / 1_000_000;
                number -= reminder * 1_000_000;
            }
            return number;
        }

        static int Part7(int number)
        {
            int res = 0, num;
            if (number >= 1_000 && number < 10_000)
            {
                for (int i = 1000; i >= 1; i /= 10)
                {
                    num = number % 10;
                    res += num * i;
                    number /= 10;
                }
                res *= 10;
                res += 800000;
                num = res % 10;
                res += 8 - num;
            }
            return res;
        }

        static int Part8(int number)
        {
            int res = 0, num1, num2;
            if (number >= 100)
            {
                num1 = number % 1000;
                num1 /= 100;
                num2 = number % 10;
                res = num1 + num2;
            }
            return res;
        }

        static int Part9(int number)
        {
            int res = 0, j = 1;
            if (number >= 100_000_000 && number < 1_000_000_000)
            {
                for (int i = Convert.ToInt32(Math.Log10(number)); i >= 0; i--)
                {

                    if (i % 2 == 0)
                    {
                        res += (number % 10) * j;
                        j *= 10;
                    }
                    number /= 10;
                }
            }
            return res;
        }

        static int Part10(int number)
        {
            int resTek = 0, resCut = 0, j = 1, numberSave = number;
            if (number >= 100_000_000 && number < 1_000_000_000)
            {
                for (int i = Convert.ToInt32(Math.Log10(number)); i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        resTek += (number % 10) * j;
                        j *= 10;
                    }
                    number /= 10;
                }
                j = 1;
                for (int i = Convert.ToInt32(Math.Log10(numberSave)); i >= 0; i--)
                {
                    if (i % 2 == 1)
                    {
                        resCut += (numberSave % 10) * j;
                        j *= 10;
                    }
                    numberSave /= 10;
                }
            }
            return resCut + resTek;
        }


    }
}