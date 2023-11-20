namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            int number = 3333;
            number = number - ((number / 1000) * 1000);
            Console.WriteLine($"Part 1 >> 7{number}8");

            // Part 2
            Console.WriteLine($"Part 2 >> {number}{number}");

            // Part 3
            int number2 = 10000;
            Console.WriteLine($"Part 3 >> 18% = {number2 = (number2 / 100) * 18}, 3% = {(number2 / 100) * 3}");

            // Part 4
            number2 = 100;
            string strNumber2 = Convert.ToString(number2);
            strNumber2 = $"{strNumber2}7";
            number2 = Convert.ToInt32(strNumber2);
            number2 = (number2 / 100) * 7;
            Console.WriteLine($"Part 4 >> {number2}");

            // Part 5
            int number3 = 1000;
            string strNumber3 = Convert.ToString(number3);
            strNumber3 = $"4{strNumber3}44";
            number3 = Convert.ToInt32(strNumber3);
            number3 = (number3 / 100) * 44;
            Console.WriteLine($"Part 5 >> {number3}"); ;

            // Part 6
            number3 = 1000;
            number3 /= 5;
            number3 /= 10;
            number3 *= number3;
            Console.WriteLine($"Part 5 >> {number3}");

            // Part 7
            number2 = 10000;
            number3 = 20000;
            int res = number2 + number3;
            string strRes = Convert.ToString(res);
            strRes = $"5{res}5";
            res = Convert.ToInt32(strRes);
            res /= 20;
            Console.WriteLine($"Part 7 >> {res}");

            // Part 8
            number2 = 1000;
            number3 = 1000000;
            number2 = (number2 / 100) * 4;
            number3 = ( number3 / 100 ) * 9;
            res = number2 + number3;
            res /= 10;
            Console.WriteLine($"Part 8 >> {res}");

            //Part 9
            number2 = 100;
            number3 = 100000;
            number2 /= 10;
            number3 /= 10;
            res = number2 + number3;
            res /= 10;
            Console.WriteLine($"Part 9 >> {res}");

            // Part 10
            number = 1000;
            number2 = 2000;
            number3 = 3000;

            number /= 100;
            number2 = (number2 / 100) * 2;
            int resNum3 = (number3 / 100) * 3;
            res = number - number2 - resNum3;
            res += (number3 / 100) * 7;
            Console.WriteLine($"Part 10 >> {res}");

        }
    }
}