namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            int num1 = 1, num2 = 2;
            if ((num1 + num2) % 2 == 0)
            {
                Console.WriteLine("Part 1:\nCem cut eddedir");
            }
            else
            {
                Console.WriteLine("Part 1:\nCem tek eddedir");
            }

            Console.WriteLine("\n--------------------------\n");

            // Part 2+3
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int resultTek = 0, resultCut = 0;
            Console.WriteLine("Part 2+3:");
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    resultCut += num;
                }
                else
                {
                    resultTek += num;
                }
            }
            Console.WriteLine($"{resultTek} tek ededler cemi");
            Console.WriteLine($"{resultCut} cut ededler cemi");
            Console.WriteLine("\n--------------------------\n");

            // Part 4
            num1 = 1234;
            int result = 0;
            int[] numArray = ConvertIntToArray(num1);
            if (num1 >= 1000)
            {
                foreach (int num in numArray)
                {
                    result += num;
                }
                Console.WriteLine($"Part 4: {result}");
            }
            else
            {
                Console.WriteLine("Part 4: Eded 4 reqemli deyil");
            }

            Console.WriteLine("\n--------------------------\n");

            //Part 5
            Student student = new Student();
            student.Name = "Zakir";
            student.LastName = "Aliev";
            student.Age = 18;
            student.Speciality = "web developer";
            student.GroupNo = 12;
            Console.WriteLine($"Part 5:\nName: {student.Name}\nLastName: {student.LastName}\nAge: {student.Age}\nSpeciality: {student.Speciality}\nGroupNo: {student.GroupNo}");
        }

        static int[] ConvertIntToArray(int number)
        {
            string numStr = number.ToString();
            int[] intArray = new int[numStr.Length];
            for (int i = 0; i < numStr.Length; i++)
            {
                intArray[i] = int.Parse(numStr[i].ToString());
            }

            return intArray;
        }

        class Student
        {
            public int Id;
            public string Name;
            public string LastName;
            public int Age;
            public string Speciality;
            public int GroupNo;
        }
    }
}
