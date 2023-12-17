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
            Console.WriteLine($"Part 8:");Part8("abc"); Console.WriteLine();
            Console.WriteLine($"Part 9:  {Part9("abasa")}\n");
            Console.WriteLine($"Part 10:  {Part10("a1as2a2")}\n");
            Console.WriteLine($"Part 11:  {Part11("a b ab ba")}\n");
            Console.WriteLine($"Part 12:  {Part12("abbaa")}\n");
            Console.WriteLine($"Part 13:  {Part13("ababa")}\n");
            Console.WriteLine($"Part 14:  {Part14("aab")}\n");
            Console.WriteLine($"Part 15:  {Part15("aabds")}\n");

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
                if ( res && text[i] != 'a')
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

        static bool Part9(string text)
        {
            // Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.? 
            bool res = true;
            string? p1, p2;
            p1 = text.Substring(0, 3);
            p2 = text.Substring(text.Length - 3, 3);
            p2 = new string(p2.Reverse().ToArray());
            if (p1 != p2)
            {
                res = false;
            }
            return res;
        }

        static string Part10(string text)
        {
            // Verilmish metinde butun reqemleri legv et
            foreach (char letter in text)
            {
                if (Char.IsNumber(letter))
                {
                    text = text.Remove(text.IndexOf(letter), 1);
                }
            }
            return text;
        }

        static string Part11(string text)
        {
            // Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve
            // eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz. 
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    text = text.Insert(i+1, "b");
                    i++;
                }
                else if (text[i] == 'b')
                {
                    text = text.Insert(i+1, "a");
                    i++;
                }
            }
            return text;
        }

        static string Part12(string text)
        {
            // Verilmish metinde en ilk ve en son {a}
            // simvolundan bashqa yerde qalan butun {a} simvollarini yox et. 
            int firstA, lastA;
            firstA = text.IndexOf('a');
            lastA = text.LastIndexOf('a');

            for (int i = 0; i < text.Length; i++)
            {
                if (i > firstA && i < lastA && text[i] == 'a')
                {
                    text = text.Remove(i, 1);
                    lastA--;
                }
            }
            return text;
        }

        static string Part13(string text)
        {
            //  Verilimish metinde butun simvollari ardicil shekilde biri balaca,
            //  biri boyuk formada cap et.
            char letter;
            for (int i = 0; i < text.Length; i+=2)
            {
                if (i <= text.Length - 1)
                {
                    letter = text[i];
                    text = text.Remove(i, 1);
                    text = text.Insert(i, Char.ToUpper(letter).ToString());
                }
            }
            return text;
        }

        static string Part14(string text)
        {
            //  Verilmish metinde butun tek yerde dayanan
            //  simvollari ondan sonra gelen simvolun
            //  BOYUK formasi ile evez et. 
            char letter;
            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 1)
                {
                    letter = text[i + 1];
                    text = text.Remove(i, 1);
                    text = text.Insert(i, Char.ToUpper(letter).ToString());
                }
            }
            return text;
        }

        static bool Part15(string text)
        {
            // Verilmish metinde ilk ve son simvol eynidirse,
            // ve metn daxilinde yanashi gelen { a}
            // simvolu varsa, ve metn daxilinde { b}
            // simvolu yoxdursa
            // o zaman bu metnde butun { c}
            // simvollari yox et ve
            // alinan metn zerkalni olub olmadigini yoxla.
            int indexA = 0, indexC = 0;
            string reverseText;
            if (text[0] == text[text.Length - 1])
            {
                indexA = text.IndexOf('a', indexA);
                if (indexA != text.Length - 1)
                {
                    l1:
                    if (text[indexA] == text[indexA + 1])
                    {
                        if (text.IndexOf('b') == -1)
                        {
                            while (text.IndexOf('c', indexC) != -1)
                            {
                                text.Remove(indexA, 1);
                                indexC++;
                            }
                            for (int i = 0; i <= text.Length - 1; i++)
                            {

                            }
                            char[] c = text.ToCharArray();
                            Array.Reverse(c);
                            reverseText = new string(c);
                            if (reverseText == text)
                            {

                                return true;
                            }
                            else
                            {
                                return false;

                            }
                        }
                        else
                        {
                                return false;

                        }
                    }
                    else
                    {
                        indexA++;
                        goto l1;
                    }
                }
                else
                {
                    Console.WriteLine("Is Not able to solve");
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
    }
}