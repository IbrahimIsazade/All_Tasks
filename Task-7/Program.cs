namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GetArray
            int count = ReadInt("Enter the count of elements: "), element;
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                element = ReadInt($"Enter the value by number {i + 1}: ");
                array[i] = element;
            }
            #endregion

            int c = ReadInt("Enter the `C`: ");
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 
                  y = { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Part1(array, c);
            Part2(array, c);
            Part3(array, c);
            Part4(array, c);
            Part5(array, c);
            Part6(x, y);
            Part7(x);
            Part8(x, y);
        }

        static void Part1(int[] arr, int c)
        {
            // 1.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen
            // elementlerini cap etmek  (c deyisheninin qiymeti istifadeciden
            // sorushulur,hemcinin a massivinin elementleri de)
            Console.WriteLine("Part 1:");
            int count = 0;
            foreach (var item in arr)
            {
                if (Math.Abs(item) < c)
                {
                    Console.Write(item + " ");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There isn't any number to satisfy your condition");
            }
            Console.WriteLine($"\n=================================");
        }

        static void Part2(int[] arr, int c)
        {
            // 2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini
            // odeyen elementlerinin ededi ortasini tapmaq
            Console.WriteLine("Part 2:");
            int count = 0, sum = 0;
            foreach (var item in arr)
            {
                if (Math.Abs(item) < c)
                {
                    sum += item;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There isn't any number to satisfy your condition");
                return;
            }

            Console.WriteLine(sum / count);
            Console.WriteLine($"\n=================================");
        }

        static void Part3(int[] arr, int c)
        {
            // 3.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c
            // sertini odeyen elementlerinin hendesi ortasini tapmaq
            Console.WriteLine("Part 3:");
            int count = 0, sum = 0;
            foreach (var item in arr)
            {
                if (Math.Abs(item) > c)
                {
                    sum *= item;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There isn't any number to satisfy your condition");
                return;
            }

            Console.WriteLine(Math.Pow(sum, 1 / count));
            Console.WriteLine($"\n=================================");
        }

        static void Part4(int[] arr, int c)
        {
            // 4.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c
            // sertini odeyen elementlerini coxdan aza dogru siralamaq
            Console.WriteLine("Part 4:");
            int[] numbers = arr.Where(x => Math.Abs(x) > c).ToArray();
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"\n=================================");
        }

        static void Part5(int[] arr, int c)
        {
            // 5.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c
            // sertini odeyen elementler icinden maximum elementi tapmaq
            Console.WriteLine("Part 5:");
            int[] numbers = arr.Where(x => Math.Abs(x) < c).ToArray();
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) { max = numbers[i]; }
            }
            Console.WriteLine(max);
            Console.WriteLine($"\n=================================");
        }

        static void Part6(int[] arrX, int[] arrY)
        {
            // 6.  X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i]
            // elementi tapmaq lazimdir ki x[i] = y[i] ^ 2
            // (eyni indexdeki x elementi hemin indexdeki y elementin
            // kvadratina beraber olsun)
            Console.WriteLine("Part 6:");
            int max;
            max = arrX.Length > arrY.Length ? arrX.Length : arrY.Length;
            for (int i = 0; i < max; i++)
            {
                if (arrX[i] == Math.Pow(arrY[i], 2))
                {
                    Console.WriteLine(arrX[i]);
                }
            }

            Console.WriteLine(max);
            Console.WriteLine($"\n=================================");
        }

        static void Part7(int[] arr)
        {
            // 7.  a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk
            // elementlerinin hendesi ve ededi ortasini tapmali
            Console.WriteLine("Part 7:");
            int max = arr[0], min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"Ededi orta: {(max + min) / 2}");
            Console.WriteLine($"Hendesi orta: {Math.Pow(max * min, 1 / 2)}");

            Console.WriteLine($"\n=================================");
        }

        static void Part8(int[] arrX, int[] arrY)
        {
            // 8. Her biri 14 elementli 2 massivin uygun elementlerini
            // bir birine vurub?alinan musbet hasillerden yeni massiv duzeltmeli
            Console.WriteLine("Part 8:");
            int[] res = new int[0];
            for (int i = 0; i < 14; i++)
            {
                if (arrX[i] * arrY[i] > 0)
                {
                    // Heç bir AI istifadə etmədən çatdı =]
                    Array.Resize(ref res, res.Length + 1);
                    res[i] = arrX[i] * arrY[i];
                }
            }

            foreach (var item in res) { Console.Write(item + " "); }

            Console.WriteLine($"\n=================================");
        }

        static void Part9(int[] arrX, int[] arrY)
        {
            // PASTE Q/T HERE
            Console.WriteLine("Part 9:");
            

            Console.WriteLine($"\n=================================");
        }

        static int ReadInt(string text)
        {
            Console.Write(text);
            string sInpt = Console.ReadLine()!;
            int inpt = Convert.ToInt32(sInpt);
            return inpt;
        }
    }
}