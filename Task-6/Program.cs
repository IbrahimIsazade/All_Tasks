namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Part 1:  {Part1("aaab")}\n");
            Console.WriteLine($"Part 2:  {Part2("ababa")}\n");
            Console.WriteLine($"Part 3:  {Part3("babaa")}\n");
            Console.WriteLine($"Part 4:  {Part4("ba")}\n");
            Console.WriteLine($"Part 5:  {Part5("debac")}\n");
            Console.WriteLine($"Part 6:  {Part6("aba")}\n");
            Console.WriteLine($"Part 7:  {Part7("abc")}\n");
            Console.WriteLine($"Part 8:");
            Part8("abc"); Console.WriteLine();
            

        }

        static int Part1(string text)
        {
            // Verilmish metnde {a} simvolun sayi {b} simvolun sayindan nece defe coxdur?
            int res, bTimes = 0, aTimes = 0;
            foreach (char letter in text)
            {
                if (letter == 'b' || letter == 'B') { bTimes++; }
                else if (letter == 'a' || letter == 'A') { aTimes++; }
            }
            res = aTimes / bTimes;
            return res;
        }

        static bool Part2(string text)
        {
            // Verilmish metnde sol terefden tek yerde dayanan simvollarin
            // hamisi {a} simvoludurmu?
            bool res = true;
            for (int i = 0; i < text.Length; i += 2)
            {
                if (text[i] != 'a')
                {
                    res = false;
                }
            }
            return res;
        }

        static int Part3(string text)
        {
            // Verilmish metnde sol terefden tek yerde
            // dayanan simvollardan necesi {b} -ye beraberdir.
            int res = 0;
            for (int i = 0; i < text.Length; i += 2)
            {
                if (text[i] == 'b')
                {
                    res++;
                }
            }
            return res;
        }

        static string Part4(string text)
        {
            // Verilmish metnde sol terefden ilk rast gelinen {a}
            // simvolunun yeri tek ededdi yoxsa cut ?
            string res;
            int index = text.IndexOf('a', StringComparison.CurrentCultureIgnoreCase);
            if (index == -1)
            {
                res = "There's no `a` ";
            }
            else if (index % 2 == 0)
            {
                res = "Odd - Tek";
            }
            else
            {
                res = "Even - Cut";
            }
            return res;
        }

        static char Part5(string text)
        {
            // Verilmish metnde sol terefden saydiqda {a},{b},{c}
            // simollarindan hansi birinci gelir?
            char[] letters = { 'a', 'b', 'c' };
            int index = text.IndexOfAny(letters);
            return text[index];
        }

        static bool Part6(string text)
        {
            // Verilmish metnde {a} simvolunun sol terefden ve sag
            // terefden indexleri eydidirmi?
            bool res = false;
            int indexRight = text.IndexOf('a');
            int indexLeft = text.LastIndexOf('a');
            if (indexLeft == indexRight)
            {
                res = true;
            }
            return res;
        }

        static bool Part7(string text)
        {
            // Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda
            // {c} simvolundan qabaq gelirmi?
            bool res = false;
            int indexA = text.IndexOf('a');
            int indexB = text.IndexOf('b');
            int indexC = text.IndexOf('c');
            if (indexA < indexB && indexB < indexC)
            {
                res = true;
            }
            return res;
        }

        static void Part8(string text)
        {
            // Verilmish metnde ilk qabagima cixan {a} simvolundan
            // sonra gelen simvolu 10 defe dalbadal cap et. 
            int index = text.IndexOf('a');
            if (index != text.Length - 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(text[index + 1] + " ");
                }
            }
            return;
        }

    }
}