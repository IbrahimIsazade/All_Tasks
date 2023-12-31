﻿namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Part 1: ");
            Console.WriteLine(Part1(1234));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 2: ");
            Console.WriteLine(Part2(123_456));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 3: ");
            Console.WriteLine(Part3(123_456_789));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 4: ");
            Console.WriteLine(Part4(12_345));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 5: ");
            Console.WriteLine(Part5(123_456));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 6: ");
            Console.WriteLine(Part6(12_345_678));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 7: ");
            Console.WriteLine(Part7(1_234));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 8: ");
            Console.WriteLine(Part8(12_345));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 9: ");
            Console.WriteLine(Part9(123_456_789));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 10: ");
            Console.WriteLine(Part10(123_456_789));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 11: ");
            Console.WriteLine(Part11(12_34_56_78));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 12: ");
            Console.WriteLine(Part12(12_345, 12_345));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 13: ");
            Console.WriteLine(Part13(12_345, 67_890, 65_213));
            Console.WriteLine("- - - - - - - -");

            Console.Write("Part 14: ");
            Console.WriteLine(Part14(123_456, 456_789, 246_824, 1_357_931));
            Console.WriteLine("- - - - - - - -");
        }

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

        static int Part11(int number)
        {
            int res = 0, num, divide = 1, multiply = 100;
            int[] groups = new int[4];
            if (number >= 10_000_000 && number < 100_000_000)
            {
                for (int i = 0; i < 4; i++)
                {
                    num = number / divide;
                    num /= 100;
                    num *= multiply;
                    groups[i] = (number - num) / divide;

                    divide *= 100;
                    multiply *= 100;
                }

                foreach (var item in groups)
                {
                    res += item;
                }
            }
            return res;
        }

        static int Part12(int number1, int number2)
        {
            int res = 0, resNum1 = 0, resNum2 = 0, num1LastNum;
            if ((number1 >= 10_000 && number1 < 100_000) && (number2 >= 10_000 && number2 < 100_000))
            {
                for (int i = 0; i < Math.Log10(number1); i++)
                {
                    resNum1 += number1 % 10;
                    number1 /= 10;
                }
                num1LastNum = resNum1 % 10;
                for (int i = 0; i < Math.Log10(number2); i++)
                {
                    resNum2 *= number2 % 10;
                    number2 /= 10;
                }

                res = ((resNum1 + resNum2) * 10) + num1LastNum;
            }
            return res;
        }

        static int Part13(int number1, int number2, int number3)
        {
            int res = 0, resNum1, resNum2, resNum3;
            if ((number1 >= 10_000 && number1 < 100_000)
               && (number2 >= 10_000 && number2 < 100_000)
               && (number3 >= 10_000 && number3 < 100_000))
            {
                resNum1 = JoinFirstSecond(number1);
                resNum2 = JoinFirstSecond(number2);
                resNum3 = JoinFirstSecond(number3);
                res += resNum1 + resNum2 + resNum3;
            }
            return (res / 2) + res;

            static int JoinFirstSecond(int number)
            {
                return ((number / 10_000) * 10) + number % 10;
            }
        }

        static int Part14(int number1, int number2, int number3, int number4)
        {
            int res = 0, resNum4 = 1;
            if ((number1 >= 100_000 && number1 < 1_000_000)
               && (number2 >= 100_000 && number2 < 1_000_000)
               && (number3 >= 100_000 && number3 < 1_000_000)
               && (number4 >= 1_000_000 && number4 < 10_000_000))
            {
                res += (number1 / 1000) + (number2 / 1000) + (number3 / 1000);
                res += number4 % 10_000;
                number4 /= 100_000;
                for (int i = 0; i < 3; i++)
                {
                    resNum4 *= number4 % 10;
                    number4 /= 10;
                }
                res -= resNum4;
                res = (res / 10) * 6;
                res *= 100;
                res += 60;
                res -= (res / 100) * 18;
            }
            return res;
        }

    }
}